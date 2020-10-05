namespace CowsAndBulls.Core
{
    using Interface;
    using CowsAndBulls.IO.Service.Interface;
    using CowsAndBulls.Constants;
    using CowsAndBulls.IO.Service;
    using CowsAndBulls.GameOptionFactory.Interface;

    public class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;
        private readonly IGameOptionFactory gameOptionFactory;
        public Engine(IWriter writer, IReader reader, IGameOptionFactory gameOptionFactory)
        {
            this.writer = writer;
            this.reader = reader;
            CustomUIConfigurator.ConfigureSettings();
            this.gameOptionFactory = gameOptionFactory;
        }
        public void Start()
        {
            writer.PrintOnNewLine(MenuMessages.MAIN_MENU_MESSAGE);
            var gameOptionChosenByPlayer = reader.ReadNewLine();
            var gameOption = gameOptionFactory.CreateGamePoint(gameOptionChosenByPlayer);
            gameOption.Run();
        }
    }
}

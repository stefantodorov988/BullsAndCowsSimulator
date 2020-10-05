namespace CowsAndBulls.Core
{
    using CowsAndBulls.IO.Service.Interface;
    using CowsAndBulls.IO.Service;
    using Interface;

    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        public Engine(IWriter writer, IReader reader)
        {
            //this.writer = writer;
            //this.reader = reader;
            //CustomIO.ConfigureSettings();
            //this.gamePointFactory = gamePointFactory;
        }
        public void Start()
        {
            //writer.PrintOnNewLine(MenuMessages.mainMenu);
            //string input = reader.ReadNewLine();
            //gamePoint = gamePointFactory.CreateGamePoint(input);
            //gamePoint.Run();
        }
    }
}

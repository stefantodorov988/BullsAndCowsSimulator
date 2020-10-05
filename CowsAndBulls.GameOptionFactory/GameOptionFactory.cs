namespace CowsAndBulls.GameOptionFactory
{
    using CowsAndBulls.Models.GameOptionsStrategyModels;
    using CowsAndBulls.Models.GameOptionsStrategyModels.Interface;
    using Interface;
    using System.Linq;
    using Unity;

    public class GameOptionFactory : IGameOptionFactory
    {
        private readonly IGameOption[] strategies;
        private readonly IUnityContainer unityContainer;

        public GameOptionFactory(IGameOption[] strategies, IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
            this.strategies = strategies;
        }
        public IGameOption CreateGamePoint(string input)
        {
            return strategies.FirstOrDefault(strategy => strategy.IsApplicable(input)) ?? unityContainer.Resolve<ExitGameOption>();
        }
    }
}

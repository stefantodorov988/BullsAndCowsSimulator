namespace CowsAndBulls.UnitTests
{
    using CowsAndBulls.CompositeRoot.DiContainer;
    using CowsAndBulls.Constants;
    using CowsAndBulls.GameOptionFactory;
    using CowsAndBulls.Models.GameOptionsStrategyModels;
    using CowsAndBulls.Models.GameOptionsStrategyModels.Interface;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Unity;

    [TestClass]
    public class GamePointFactoryTests
    {
        public IUnityContainer Container { get; set; }
        public IGameOption SinglePlayer { get; set; }
        public IGameOption MultiPLayer { get; set; }
        public IGameOption Exit { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Container = UnityLoader.LoadContainer();
            SinglePlayer = Container.Resolve<SinglePlayerGameOption>();
            MultiPLayer = Container.Resolve<MultiPlayerGameOption>();
            Exit = Container.Resolve<ExitGameOption>();
        }

        [TestMethod]
        public void CanCreateSinglePlayerGameOption()
        {
            var factory = new GameOptionFactory(new IGameOption[] { SinglePlayer, MultiPLayer, Exit }, Container);
            var gameOption = factory.CreateGamePoint(UserInputConstants.SINGLE_PLAYER);
            bool created = false;
            if(gameOption != null)
            {
                created = true;
            }
            Assert.IsTrue(created);
        }

        [TestMethod]
        public void CanCreateMultiPlayerGameOption()
        {
            var factory = new GameOptionFactory(new IGameOption[] { SinglePlayer, MultiPLayer, Exit }, Container);
            var gameOption = factory.CreateGamePoint(UserInputConstants.MULTI_PLAYER);
            bool created = false;
            if (gameOption != null)
            {
                created = true;
            }
            Assert.IsTrue(created);

        }
        [TestMethod]
        public void CanCreateExitGameOption()
        {
            var factory = new GameOptionFactory(new IGameOption[] { SinglePlayer, MultiPLayer, Exit }, Container);
            var gameOption = factory.CreateGamePoint(UserInputConstants.EXIT);
            bool created = false;
            if (gameOption != null)
            {
                created = true;
            }
            Assert.IsTrue(created);
        }
    }
}

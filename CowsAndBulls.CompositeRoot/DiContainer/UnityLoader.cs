namespace CowsAndBulls.CompositeRoot.DiContainer
{
    using CowsAndBulls.GameOptionFactory.Interface;
    using CowsAndBulls.GameOptionFactory;
    using CowsAndBulls.IO.Service;
    using CowsAndBulls.IO.Service.Interface;
    using Unity;
    using CowsAndBulls.Models.GameOptionsStrategyModels.Interface;
    using CowsAndBulls.Models.GameOptionsStrategyModels;
    using CowsAndBulls.CompareService;
    using CowsAndBulls.CompareService.Interface;
    using CowsAndBulls.Digits.Service.Interface;
    using CowsAndBulls.Digits.Service;
    using CowsAndBulls.BCTreeFactory.Interface;
    using CowsAndBulls.BCTreeFactory;

    public class UnityLoader
    {
        public static IUnityContainer LoadContainer()
        {
            IUnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<IReader, Reader>();
            unityContainer.RegisterType<IWriter, Writer>();

            unityContainer.RegisterType<IGameOption, SinglePlayerGameOption>("Single Player");
            unityContainer.RegisterType<IGameOption, MultiPlayerGameOption>("Multi player");
            unityContainer.RegisterType<IGameOption, ExitGameOption>("Exit");
            unityContainer.RegisterType<IGameOptionFactory, GameOptionFactory>();
            unityContainer.RegisterType<IBCTreeFactory, BCTreeFactory>(); 

            unityContainer.RegisterType<ICodeCompareService, CodeCompareService>();
            unityContainer.RegisterType<IDigitsService, DigitsService>();

            unityContainer.RegisterInstance(unityContainer);

            return unityContainer;
        }
    }
}

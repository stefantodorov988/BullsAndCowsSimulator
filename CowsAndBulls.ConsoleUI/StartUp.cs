namespace CowsAndBulls.ConsoleUI
{
    using CowsAndBulls.CompositeRoot.DiContainer;
    using CowsAndBulls.Core;
    using Unity;

    class StartUp
    {
        static void Main()
        {
            IUnityContainer unityContainer = UnityLoader.LoadContainer();
            var engine = unityContainer.Resolve<Engine>();
            engine.Start();
        }
    }
}

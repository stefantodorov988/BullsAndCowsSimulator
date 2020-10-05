namespace CowsAndBulls.GameOptionFactory.Interface
{
    using CowsAndBulls.Models.GameOptionsStrategyModels.Interface;
    public interface IGameOptionFactory
    {
        IGameOption CreateGamePoint(string input);
    }
}

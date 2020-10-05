namespace CowsAndBulls.Models.GameOptionsStrategyModels.Interface
{
    public interface IGameOption
    {
        void Run();
        bool IsApplicable(string input);
    }
}
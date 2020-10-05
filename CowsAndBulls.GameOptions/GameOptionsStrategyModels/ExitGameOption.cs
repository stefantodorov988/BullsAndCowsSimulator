namespace CowsAndBulls.Models.GameOptionsStrategyModels
{
    using CowsAndBulls.Constants;
    using Interface;
    using System;
    public class ExitGameOption : IGameOption
    {
        public ExitGameOption()
        {

        }
        public void Run()
        {
            Environment.Exit(0);
        }
        public bool IsApplicable(string input)
        {
            return input == UserInputConstants.EXIT;
        }
    }
}

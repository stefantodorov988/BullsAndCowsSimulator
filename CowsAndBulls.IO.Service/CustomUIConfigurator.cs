namespace CowsAndBulls.IO.Service
{
    using CowsAndBulls.Constants;
    using System;
    public class CustomUIConfigurator
    {
        public static void ConfigureSettings()
        {
            Console.WindowWidth = ConsoleConfigConstants.CONSOLE_WIDTH;
            Console.WindowHeight = ConsoleConfigConstants.CONSOLE_HEIGHT;
        }
    }
}

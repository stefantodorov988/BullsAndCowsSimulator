namespace CowsAndBulls.IO.Service
{
    using System;
    using Interface;
    public class Writer : IWriter
    {
        public void ClearInterface()
        {
            Console.Clear();
        }
        public void PrintOnNewLine(string value)
        {
            Console.WriteLine(value);
        }
        public void PrintOnLine(string value)
        {
            Console.Write(value);
        }

        public void ChangeOutputColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
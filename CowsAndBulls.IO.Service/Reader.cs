namespace CowsAndBulls.IO.Service
{
    using Interface;
    using System;

    public class Reader : IReader
    {
        public string ReadNewLine()
        {
            return Console.ReadLine();
        }
    }
}

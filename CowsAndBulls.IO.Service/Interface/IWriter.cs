namespace CowsAndBulls.IO.Service.Interface
{
    using System;
    public interface IWriter
    {
        void ClearInterface();
        void PrintOnNewLine(string value);
        void PrintOnLine(string value);
        void ChangeOutputColor(ConsoleColor color);
    }
}

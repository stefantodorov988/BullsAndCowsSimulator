namespace CowsAndBulls.Digits.Service.Interface
{
    using System.Collections.Generic;
    public interface IDigitsService
    {
        string GenerateRandomCode(int numberOfDigits);
    }
}
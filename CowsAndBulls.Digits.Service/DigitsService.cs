namespace CowsAndBulls.Digits.Service
{
    using Interface;
    using System;
    using System.Collections.Generic;

    public class DigitsService : IDigitsService
    {
        public string GenerateRandomCode(int numberOfDigits)
        {
            var numbers = new HashSet<int>();
            Random rnd = new Random();

            while (numbers.Count != numberOfDigits)
                numbers.Add(rnd.Next(0, 9));

            return string.Join("", numbers);
        }
    }
}

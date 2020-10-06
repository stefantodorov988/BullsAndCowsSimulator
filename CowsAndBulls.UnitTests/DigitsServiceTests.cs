namespace CowsAndBulls.UnitTests
{
    using CowsAndBulls.Digits.Service;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class DigitsServiceTests
    {
        [TestMethod]
        public void CanGenerateFourDigitCode()
        {
            var digitsService = new DigitsService();

            var fourDigitCode = digitsService.GenerateRandomCode(4);

            var areAllCharsUnique = true;
            var charCollection = new HashSet<char>();
            foreach (var ch in fourDigitCode)
            {
                if (!charCollection.Add(ch))
                {
                    areAllCharsUnique = false;
                }
            }
            Assert.IsTrue(areAllCharsUnique);
        }
    }
}

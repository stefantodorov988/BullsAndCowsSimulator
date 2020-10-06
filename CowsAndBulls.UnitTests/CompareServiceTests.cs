namespace CowsAndBulls.UnitTests
{
    using CowsAndBulls.CompareService;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class CompareServiceTests
    {
        [TestMethod]
        public void CanCompareCodeZeroCowsZeroBulls()
        {
            var compareService = new CodeCompareService();
            var result = compareService.CompareCode("0123", "5678");

            var expected = false;

            if (result.CowsNumber == 0 && result.BullsNumber == 0)
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void CanCompareCodeTwoCowsZeroBulls()
        {
            var compareService = new CodeCompareService();
            var result = compareService.CompareCode("0123", "5319");

            var expected = false;

            if (result.CowsNumber == 2 && result.BullsNumber == 0)
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void CanCompareCodeZeroCowsTwoBulls()
        {
            var compareService = new CodeCompareService();
            var result = compareService.CompareCode("6378", "5478");

            var expected = false;

            if (result.CowsNumber == 0 && result.BullsNumber == 2)
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void CanCompareCodeTwoCowsTwoBulls()
        {
            var compareService = new CodeCompareService();
            var result = compareService.CompareCode("9876", "9867");

            var expected = false;

            if (result.CowsNumber == 2 && result.BullsNumber == 2)
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void CanCompareCodeZeroCowsFourBulls()
        {
            var compareService = new CodeCompareService();
            var result = compareService.CompareCode("6583", "6583");

            var expected = false;

            if (result.CowsNumber == 0 && result.BullsNumber == 4)
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }
    }
}
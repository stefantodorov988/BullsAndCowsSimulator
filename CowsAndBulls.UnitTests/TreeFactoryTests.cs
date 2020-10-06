namespace CowsAndBulls.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class TreeFactoryTests
    {
        [TestMethod]
        public void CanCreateTree()
        {
            var factory = new BCTreeFactory.BCTreeFactory();

            var result = factory.CreateTree();
            bool created = false;
            if(result != null && result.Root != null)
                created = true;

            Assert.IsTrue(created);

        }
    }
}

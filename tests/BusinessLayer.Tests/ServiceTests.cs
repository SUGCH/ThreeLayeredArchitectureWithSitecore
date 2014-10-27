namespace BusinessLayer.Tests
{
    using System.Linq;

    using DataLayer;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void SortByDateTest()
        {
            // prepare
            var repository = new MockRepository();
            var service = new SortByDateService(repository);

            // act
            var news = service.GetNews().ToList();

            // assert
            Assert.AreEqual("News 2", news.First().Title);
            Assert.AreEqual("News 1", news.Skip(1).First().Title);
            Assert.AreEqual("News 3", news.Skip(2).First().Title);
        }

        [TestMethod]
        public void SortByRank()
        {
            // prepare
            var repository = new MockRepository();
            var service = new SortByRankService(repository);

            // act
            var news = service.GetNews().ToList();

            // assert
            Assert.AreEqual("News 1", news.First().Title);
            Assert.AreEqual("News 2", news.Skip(1).First().Title);
            Assert.AreEqual("News 3", news.Skip(2).First().Title);
        }
    }
}

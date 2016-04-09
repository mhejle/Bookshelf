using NUnit.Framework;

namespace Bookshelf.Server.Shared.Test
{
    [TestFixture, Category(TestCatagory.Unit)]
    public class DummyTest
    {

        [Test]
        public void TestThatWeCanTest()
        {
            Dummy d = new Dummy(true);
            Assert.IsTrue(d.Status);
        }

    }
}

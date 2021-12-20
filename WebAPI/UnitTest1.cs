using NUnit.Framework;

namespace WebAPI
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var request = new RequestMaker();
            var  upl = request.upload();
            Assert.IsTrue(upl.IsSuccessful, upl.Content);
        }
        [Test]
        public void Test2()
        {
            var request = new RequestMaker();
            var upl = request.get_file_metadata();
            Assert.IsTrue(upl.IsSuccessful, upl.Content);
        }
        [Test]
        public void Test3()
        {
            var request = new RequestMaker();
            var upl = request.delete();
            Assert.IsTrue(upl.IsSuccessful, upl.Content);
        }
    }
}
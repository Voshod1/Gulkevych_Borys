using NUnit.Framework;

namespace WebAPI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var t = new RequestMaker();
            var  upl = t.upload();
            Assert.IsTrue(upl.IsSuccessful, upl.Content);
        }
        [Test]
        public void Test2()
        {
            var t = new RequestMaker();
            var upl = t.get_file_metadata();
            Assert.IsTrue(upl.IsSuccessful, upl.Content);
        }
        [Test]
        public void Test3()
        {
            var t = new RequestMaker();
            var upl = t.delete();
            Assert.IsTrue(upl.IsSuccessful, upl.Content);
        }
    }
    public class IdParse
    {
        public string id { get; set; }
        public string error_summary { get; set; }

    }
}
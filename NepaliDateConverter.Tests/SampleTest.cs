using NUnit.Framework;

namespace NepaliDateConverter.Tests
{
    [TestFixture]
    class SampleTest
    {
        [Test]
        public void ShouldReturnHelloWorld()
        {
            var con = new Sample();
            Assert.That(con.Demo(), Is.EqualTo("Hello world"));
        }
    }
}

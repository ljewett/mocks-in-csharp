using NUnit.Framework;

namespace ClaimsTests
{
    public class ClaimControllerTests
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual("Foo", "Foo");
        }
    }
}
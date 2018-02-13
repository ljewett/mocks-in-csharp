using Xunit;

namespace ClaimsTests
{
    public class ClaimControllerTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal("Foo", "Foo");
        }
    }
}
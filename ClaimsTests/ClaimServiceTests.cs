using Xunit;

namespace ClaimsTests
{
    public class ClaimServiceTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal("Foo", "Foo");
        }
    }
}
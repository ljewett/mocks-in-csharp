using Xunit;

namespace ClaimsTests
{
    public class ClaimsServiceTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal("Foo", "Foo");
        }
    }
}
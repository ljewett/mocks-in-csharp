using Xunit;

namespace ClaimsTests
{
    public class ClaimStorageTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal("Foo", "Foo");
        }
    }
}
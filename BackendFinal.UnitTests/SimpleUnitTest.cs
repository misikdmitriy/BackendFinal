using Shouldly;
using Xunit;

namespace BackendFinal.UnitTests
{
    public class SimpleUnitTest
    {
        [Fact]
        public void AssertTrueShouldNotFail()
        {
            true.ShouldBe(true);
        }
    }
}

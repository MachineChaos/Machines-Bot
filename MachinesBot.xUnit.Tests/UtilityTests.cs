using Xunit;
using MachinesBot;

namespace MachinesBot.xUnit.Tests
{
    public class UtilityTests
    {
        [Fact]
        public void TestName()
        {
            const int expected = 5;

            var actual = Utilities.MyUtility(expected);

            Assert.Equal(expected, actual);
        }
    }
}

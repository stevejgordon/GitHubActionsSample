using SampleLibrary;
using Xunit;

namespace tests
{
    public class CalculatorTests
    {
        [Fact]
        public void DoubleReturnsExpectedValue()
        {
            var sut = new Calculator();

            var result = sut.Double(10);

            Assert.Equal(20, result);
        }
    }
}

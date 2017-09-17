using Xunit;

namespace FizzBuzzD.Tests
{
    public class FizzBuzzTests
    {
        private readonly IFizzBuzzService _fizzBuzzService = new StandardFizzBuzzService(3, 5);

        [Theory]
        [InlineData(0, 0)]
        [InlineData("0", 0)]
        [InlineData(-1, -1)]
        [InlineData(0.0, 0)]
        [InlineData("a", null)]
        public void GetIntFromString_NullIfCastFails(string input, int? expectedResult)
        {
            Assert.Equal(_fizzBuzzService.GetIntFromString(input), expectedResult);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(3, true)]
        [InlineData(-3, true)]
        [InlineData(999, true)]
        [InlineData(5, false)]
        [InlineData(-1000, false)]
        public void IsFizz(int input, bool expectedResult)
        {
            Assert.Equal(_fizzBuzzService.IsFizz(input), expectedResult);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(5, true)]
        [InlineData(-5, true)]
        [InlineData(1000, true)]
        [InlineData(3, false)]
        [InlineData(-997, false)]
        public void IsBuzz(int input, bool expectedResult)
        {
            Assert.Equal(_fizzBuzzService.IsBuzz(input), expectedResult);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(3, false)]
        [InlineData(5, false)]
        [InlineData(15, true)]
        [InlineData(-15, true)]
        [InlineData(1000, false)]
        public void IsFizzBuzz(int input, bool expectedResult)
        {
            Assert.Equal(_fizzBuzzService.IsBuzz(input) && _fizzBuzzService.IsFizz(input), expectedResult);
        }
    }
}
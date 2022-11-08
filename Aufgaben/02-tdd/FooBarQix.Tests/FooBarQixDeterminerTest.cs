using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_WenNuber_Is1()
        {
            int number = 1;
            string expected = "1";

            var actual = FooBarQixDeterminer.Determine(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Foo")]
        [InlineData(4, "4")]
        [InlineData(5, "Bar")]
        [InlineData(6, "Foo")]
        [InlineData(7, "Qix")]
        [InlineData(8, "8")]
        [InlineData(9, "Foo")]
        [InlineData(10, "Bar")]
        [InlineData(13, "13")]
        [InlineData(15, "FooBar")]
        [InlineData(21, "FooQix")]
        [InlineData(105, "2")]
        public void Determine_Number_ShouldReturnsCorrectResult(int number, string expected)
        {
            var result = FooBarQixDeterminer.Determine(number);
            Assert.Equal("Foo", result);
        }
    }
}
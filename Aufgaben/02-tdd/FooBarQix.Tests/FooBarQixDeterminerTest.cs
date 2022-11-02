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

        public void Determine_WhenNuberUsThree_ShouldReturnFoo(int number, string expected)
        {
           

            var result = FooBarQixDeterminer.Determine(number);
            Assert.Equal("Foo", result);

        }
    }
}
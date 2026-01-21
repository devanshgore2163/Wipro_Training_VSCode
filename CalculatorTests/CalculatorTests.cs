using Xunit;
using CalculatorLib;
using System;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc;

        public CalculatorTests()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            var result = _calc.Add(10, 5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            var result = _calc.Subtract(10, 5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            var result = _calc.Multiply(10, 5);
            Assert.Equal(50, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectResult()
        {
            var result = _calc.Divide(10, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
        }

        [Fact]
        public void Add_WithZero_ReturnsSameNumber()
        {
            var result = _calc.Add(10, 0);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Subtract_WithZero_ReturnsSameNumber()
        {
            var result = _calc.Subtract(10, 0);
            Assert.Equal(10, result);
        }
    }
}

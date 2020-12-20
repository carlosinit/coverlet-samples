using System;
using CoverletSamples.Code;
using Xunit;

namespace CoverletSamples.CodeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, Calculator.Sum(1, 1));
            Assert.Equal(1, Calculator.Multiply(1, 1));
            Assert.Equal(1, Calculator.Subtract(2, 1));
            Assert.Equal(1, Calculator.Power(1, 1));
            Assert.Equal(1, Calculator.Divide(1, 1));

            Assert.Throws<InvalidOperationException>(() => Calculator.Divide(1, 0));

            // Assert.True(Calculator.IsPrime(1));
            // Assert.True(Calculator.IsPrime(2));
            // Assert.True(Calculator.IsPrime(3));
            // Assert.False(Calculator.IsPrime(4));
            // Assert.True(Calculator.IsPrime(5));
            // Assert.False(Calculator.IsPrime(6));
            // Assert.True(Calculator.IsPrime(7));
            // Assert.False(Calculator.IsPrime(8));
            // Assert.False(Calculator.IsPrime(9));
            // Assert.False(Calculator.IsPrime(10));
            // Assert.True(Calculator.IsPrime(97));
        }
    }
}

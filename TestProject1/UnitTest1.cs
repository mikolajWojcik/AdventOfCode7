using System;
using System.Collections.Generic;
using AdventOfCode7;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
            var eater = new CrabEater(list);

            var result = eater.CalculateOptimalCost();
            
            Assert.Equal(168, result);
        }
        
        [Theory]
        [InlineData(2,206)]
        [InlineData(5,168)]
        public void Test2(int index, int expected)
        {
            var list = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
            var eater = new CrabEater(list);

            var result = eater.CalculateResultForIndex(index);
            
            Assert.Equal(expected, result);
        }
    }
}
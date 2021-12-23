using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode7
{
    public class CrabEater
    {
        private readonly List<int> _sortedNumbers;

        public CrabEater(List<int> positions)
        {
            var max = positions.Max();
            _sortedNumbers = new int[max + 1].ToList();

            foreach (var position in positions)
            {
                _sortedNumbers[position]++;
            }
        }

        public int CalculateOptimalCost()
        {
            int? minResult = null;
            for (int i = 0; i < _sortedNumbers.Count; i++)
            {
                var result = CalculateResultForIndex(i);

                if (minResult == null || minResult > result)
                {
                    minResult = result;
                }
            }

            return minResult ?? 0;
        }

        public int CalculateResultForIndex(int i)
        {
            var result = _sortedNumbers.Select((x, index) =>
            {
                if (index == i || x == 0)
                    return 0;

                var steps = Math.Abs(index - i);
                var fuel = Enumerable.Range(1, steps).Sum();
                return fuel * x;
            }).Sum();
            return result;
        }
    }
}
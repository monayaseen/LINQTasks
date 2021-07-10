using System.Collections.Generic;
using System.Linq;

namespace LINQTasks
{
    public class SquareSequenceTest
    {
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers.Select(value => value * value).SequenceEqual(squares);
        }
    }
}
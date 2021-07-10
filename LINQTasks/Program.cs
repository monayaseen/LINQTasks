using System;
using System.Collections.Generic;

namespace LINQTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> squares = new List<int> { 1, 4, 9, 16, 25 };
            
            IEnumerable<int> numbers1 = new List<int> {1, 2, 5}; 
            IEnumerable<int > squares1 = new List<int> {1, 4, 9};
            
            Console.WriteLine(SquareSequenceTest.TestForSquares(numbers,squares));
            Console.WriteLine(SquareSequenceTest.TestForSquares(numbers1,squares1));
        }
    }
}
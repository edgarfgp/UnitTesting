

using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    /// <summary>
    /// Math class
    /// </summary>
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;

        }
        /// <summary>
        /// This method retrive the greater number
        /// </summary>
        /// <param name="a">first of the two arguments to compare</param>
        /// <param name="b">second of the two arguments to compare</param>
        /// <returns>wich of the param es greater</returns>
        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}
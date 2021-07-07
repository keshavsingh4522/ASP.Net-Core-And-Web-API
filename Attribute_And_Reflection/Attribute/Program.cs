using System;
using System.Collections.Generic;

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Add(12,23);
            Console.WriteLine("12 + 13 = {0}", result);

            result = Calculator.Add(new List<int>() { 10,20,30});
            Console.WriteLine("10 + 20 + 30 = {0}", result);
        }
    }
    class Calculator
    {
        // generate error if you dont to like the old method
        // [Obsolete(" Use public static int Add(List<int> arr) Method",true)]

        // warning
        // [Obsolete]

        // warning with message
        [Obsolete(" Use public static int Add(List<int> arr) Method")]
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(List<int> arr)
        {
            int sum = 0;
            arr.ForEach(x => sum += x);
            return sum;
        }
    }
}

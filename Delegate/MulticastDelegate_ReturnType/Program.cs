using System;

namespace MulticastDelegate_ReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDelegate del1 = new SimpleDelegate(FunctionOne);
            del1 += FunctionTwo;
            del1 += new SimpleDelegate(FunctionThree);

            // del4 is multicast delegtae
            Console.WriteLine("--------------Added functionOne,Two,Three-----------------");
            var result = del1();
            Console.WriteLine("Returned value is {0}",result);

            Console.WriteLine("--------------removed functionThree delegate -----------------");
            del1 -= FunctionThree;
            result = del1();
            Console.WriteLine("Returned value is {0}", result);
        }
        public delegate int SimpleDelegate();

        public static int FunctionOne()
        {
            return 1;
        }
        public static int FunctionTwo()
        {
            return 2;
        }
        public static int FunctionThree()
        {
            return 3;
        }
    }
}

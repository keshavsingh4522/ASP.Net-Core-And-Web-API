using System;

namespace MulticastDelegate_2nd_Approach
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
            del1();

            Console.WriteLine("--------------removed functionOne delegate -----------------");
            del1 -= FunctionOne;
            del1();

        }
        public delegate void SimpleDelegate();

        public static void FunctionOne()
        {
            Console.WriteLine("Delegate one Invoked");
        }
        public static void FunctionTwo()
        {
            Console.WriteLine("Delegate two Invoked");
        }
        public static void FunctionThree()
        {
            Console.WriteLine("Delegate three Invoked");
        }
    }
}

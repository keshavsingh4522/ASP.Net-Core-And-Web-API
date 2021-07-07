using System;

namespace MulticastDelegate_1st_Approach
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDelegate del1, del2, del3, del4;
            del1 = new SimpleDelegate(FunctionOne);
            del2 = new SimpleDelegate(FunctionTwo);
            del3 = new SimpleDelegate(FunctionThree);

            // del4 is multicast delegtae
            Console.WriteLine("--------------del4 = del1 + del2 + del3 -----------------");
            del4 = del1 + del2 + del3;
            del4();

            Console.WriteLine("--------------del4 -= del2 -----------------");
            del4 -=del2;
            del4();

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

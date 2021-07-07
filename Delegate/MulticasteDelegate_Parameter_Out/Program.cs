using System;

namespace MulticasteDelegate_Parameter_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int ParameterTypeValue;

            SimpleDelegate del1 = new SimpleDelegate(FunctionOne);
            del1 += FunctionTwo;
            del1 += new SimpleDelegate(FunctionThree);

            // del4 is multicast delegtae
            Console.WriteLine("--------------Added functionOne,Two,Three-----------------");
            del1(out ParameterTypeValue);
            Console.WriteLine("ParameterTpeValue is {0}", ParameterTypeValue);

            Console.WriteLine("--------------removed functionThree delegate -----------------");
            del1 -= FunctionThree;
            del1(out ParameterTypeValue);
            Console.WriteLine("ParameterTpeValue is {0}", ParameterTypeValue);

        }
        public delegate void SimpleDelegate(out int parameterType);

        public static void FunctionOne(out int number)
        {
            number = 1;
        }
        public static void FunctionTwo(out int number)
        {
            number = 2;
        }
        public static void FunctionThree(out int number)
        {
            number = 3;
        }
    }
}

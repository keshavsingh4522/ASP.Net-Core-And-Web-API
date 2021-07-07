using System;

namespace Delegate
{
    class Program
    {
        // delegate is a type saving pointer function
        // signater of delegate or function both should be matched
        public delegate void HelloFunctionDelegate(string msg);
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("hi i am from delegate");
        }
        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}

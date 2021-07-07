using System;
using System.Collections.Generic;
using System.Linq;

namespace StringOutputProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            string INPUT1 = Console.ReadLine();
            string INPUT2 = Console.ReadLine();
            string INPUT3 = Console.ReadLine();
            string output1 = "";
            string output2 = "";
            string output3 = "";

            SubStrings(INPUT1,ref output1,ref output2,ref output3);
            SubStrings(INPUT2, ref output1, ref output2, ref output3);
            SubStrings(INPUT3, ref output1, ref output2, ref output3);

            //toggle
            output2 = ToggleString(output2);

            Console.WriteLine("Output1: "+output3);
            Console.WriteLine("Output2: " + output1);
            Console.WriteLine("Output3: " + output2);

        }

        public static void SubStrings(string str,ref string output1, ref string output2, ref string output3)
        {
            int length = str.Length; 
            int c = length/3;

            if (length % 3 == 0)
            {
                output1 += str.Substring(0, c);
                output2 += str.Substring(c, c );
                output3 += str.Substring(c * 2);
            }
            else if (length % 3 == 1)
            {
                output3 += str.Substring(0, c);
                output1 += str.Substring(c, c + 1);
                output2 += str.Substring(c * 2 + 1);
            }
            else
            {
                output2 += str.Substring(0, c + 1);
                output3 += str.Substring(c + 1, c );
                output1 += str.Substring(c * 2 + 1);
            }
        }

        public static string ToggleString(string str) {
            string s = "";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i] >= 'a')
                {
                    s +=(char)(str[i] - 32);
                }
                else
                {
                    s += (char)(str[i] + 32);
                }
            }
            return s;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            int[] arr = new int[] { 1,2,3,4,5};
            var m = arr.GetEnumerator();

            // Console.WriteLine(m.Current); --> before movenext we can call this

            Console.WriteLine(m.MoveNext());
            Console.WriteLine(m.Current);

            Console.WriteLine(m.MoveNext());
            Console.WriteLine(m.Current);

            Console.WriteLine(m.MoveNext());
            Console.WriteLine(m.Current);

            Console.WriteLine(m.MoveNext());
            Console.WriteLine(m.Current);

            Console.WriteLine(m.MoveNext());
            Console.WriteLine(m.Current);

            Console.WriteLine(m.MoveNext());
           // Console.WriteLine(m.Current);--> if all value called then we cant use this

            Console.WriteLine("");

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region ArrayList
            Console.WriteLine("----ArrayList----");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(89);
            arrayList.Add("Keshav Singh");
            arrayList.Add('K');
            arrayList.Add(45.90);
            arrayList.Add(2.0);
            arrayList.Insert(1,"inserted at index 1");

            foreach(var x in arrayList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("arrayList1");
            ArrayList arrayList1 = new ArrayList() {
                23,56,"Prop",'h'
            };
            arrayList1.Add(arrayList);
            foreach (var x in arrayList1)
            {
                Console.WriteLine(x);
            }
            #endregion

            #region List
            Console.WriteLine("--------List-------");
            List<int> list1 = new List<int>()
            {
                1,2,3,4222,5,6,7,8345,945454,10
            };
            // print using linq
            list1.ForEach(m => Console.WriteLine(m + "\r"+"d"));
            
            Console.WriteLine((int)'\r');
            #endregion
        }
    }
}

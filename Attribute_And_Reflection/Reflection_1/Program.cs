using System;
using System.Reflection;

namespace Reflection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Type
            // same behaviour

            //Type T = Type.GetType("Reflection_1.Customer");

            //Type T = typeof(Customer);

            Customer c1 = new Customer();
            Type T = c1.GetType();

            #endregion


            Console.WriteLine("Full name : {0}", T.FullName);
            Console.WriteLine("Just name : {0}", T.Name);
            Console.WriteLine("namespace name : {0}", T.Namespace);

            Console.WriteLine("\n ------------------ Properties in Customers ------------------");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name+" : "+property.PropertyType.Name);
            }

            Console.WriteLine("\n ------------------ Methods in Customers ------------------");
            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name+" : "+method.ReturnType.Name);
            }

            Console.WriteLine("\n ------------------ Constructor in Customers ------------------");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                // name does not give more info
                // Console.WriteLine(constructor.Name);
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Customer()
        {
            Id = -1;
            Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("ID = {0}",this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}

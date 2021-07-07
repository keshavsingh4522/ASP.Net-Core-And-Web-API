using System;
using System.Collections.Generic;

namespace DelegateUsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { Id = 101, Name = "Keshav Singh", Salary = 16000, Experience = 1 });
            emp.Add(new Employee { Id = 102, Name = "Prakash", Salary = 56000, Experience = 6 });
            emp.Add(new Employee { Id = 103, Name = "Radhe", Salary = 160000, Experience = 16 });
            emp.Add(new Employee { Id = 104, Name = "Pradeep", Salary = 16000, Experience = 0 });

            IsPromotable del = new IsPromotable(IsEligble);

            Employee.PromoteEmployee(emp,del);
        }
        public static bool IsEligble(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            return false;
        }
    }

    public delegate bool IsPromotable(Employee emp);
    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeesList,IsPromotable isEligbleToPromote)
        {
            foreach(Employee emp in employeesList)
            {
                if(isEligbleToPromote(emp))
                {
                    Console.WriteLine(emp.Name+" Promoted");
                }
            }
        }
    }
}

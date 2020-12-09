using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Q1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> o1 = (p, n, r) => (p * n * r)/100;
            Console.WriteLine("Simple Interest :" + o1(1000, 100, 5));
            Console.ReadLine();
        }
    }
}

namespace Assignment6Q2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Func<int,int,bool> o2 = (a,b) => a > b;
            Console.WriteLine(o2(20,10));
            Console.ReadLine();
        }
    }

}

namespace Assignment6Q3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Employee e = new Employee();
            Func<Employee, decimal> o3 = emp => emp.getBasic(e);  
            Console.WriteLine("Basic salary of Employee : " + o3(e));
            Console.ReadLine();
        }
        class Employee
        {
            public decimal basic = 15000;

            public decimal getBasic(Employee emp)
            {
                return emp.basic;
            }
        }

    }
}

namespace Assignment6Q4
{
    class Program
    {
        static void Main4(string[] args)
        {
            Predicate<int> o2 = a => a % 2 == 0;
            Console.WriteLine(o2(6));
            Console.ReadLine();
        }
    }
}

namespace Assignment6Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Predicate<Employee> o5 = emp => emp.IsGreaterThan10000(e);
            Console.WriteLine("IsGreater = " + o5(e));
            Console.ReadLine();
        }
        class Employee
        {
            public decimal basic = 15000;

            public decimal getBasic(Employee emp)
            {
                return emp.basic;
            }

            public bool IsGreaterThan10000(Employee emp1)
            {
                return emp1.basic > 10000;
            }
        }

    }
}
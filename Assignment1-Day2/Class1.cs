using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   class Program
    { 
        static void Main()
        {
			Employee o1 = new Employee("Amol", 123465, 10);
			Employee o2 = new Employee("Amol", 123465);
			Employee o3 = new Employee("Amol");
			Employee o4 = new Employee();

			Console.WriteLine(o1.Empno);
			Console.WriteLine(o2.Empno);
			Console.WriteLine(o3.Empno);

			Console.WriteLine(o3.Empno);
			Console.WriteLine(o2.Empno);
			Console.WriteLine(o1.Empno);

			Console.ReadLine();
		}
    }
    public class Employee
    {
		private static int auto;

		private string name;

		public string Name
		{
			set
			{
				if (value != null)
					name = value;
				else
                    Console.WriteLine("name should not be blank");
			}

			get
			{
				return name;
			}
		}

		private int empno;

		public int Empno
		{
			get
			{
				return empno;
			}
		}

		private decimal basic;

		public decimal Basic
		{
			set
			{
				if (value > 10 && value < 1500000)
					basic = value;
				else
                    Console.WriteLine("Not in given range");
			}
			get
			{
				return basic;
			}
		}

private short deptno;

public short Deptno
		{
			set
			{
				if (value > 0)
					deptno = value;
				else
                    Console.WriteLine("Dept no must be greater than 0");
			}
			get
			{
				return deptno;
			}
		}

		public decimal getNetSalary()

		{

			decimal netsal;

			netsal = basic + 4000 + 1000;

			return netsal;

		}

		public Employee()
		{
			auto++;
			this.empno = auto;
		}

		public Employee(string name)
		{
			this.name = name;
			auto++;
			this.empno = auto;
		}

		public Employee(string name, decimal basic)
		{
			this.name = name;
			this.basic = basic;
			auto++;
			this.empno = auto;
		}

		public Employee(String name, decimal basic, short deptno)
		{
			this.name = name;
			this.basic = basic;
			this.deptno = deptno;
			auto++;
			this.empno = auto;
		}
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
			GeneralManager o = new GeneralManager("abc","CEO","dhanashri",40000,01);
			Console.WriteLine(o.CalcNetSalary());
			Console.ReadLine();
        }

        public abstract class Employee
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
                        Console.WriteLine("Name should not be blank");
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

			private short deptno;

			public short Deptno
			{
				set
				{
					if (value > 0)
						deptno = value;
					else
                        Console.WriteLine("Deptno should be greater than 0");
				}
				get
				{
					return deptno;
				}
			}

			public decimal basic;

			public abstract decimal Basic
			{
				set;
				get;
			}

			public abstract decimal CalcNetSalary();

			public Employee(string name, decimal basic,short deptno)
			{
				this.Name = name;
				this.Basic = basic;
				this.Deptno = deptno;
				auto++;
				this.empno = auto;
			}
		}

		public class Manager : Employee
		{
			public override decimal CalcNetSalary()
			{
				decimal netsalary;
				netsalary = basic + 1000 * 1000;
				return netsalary;
			}

			private string designation;

            public string Designation
            {
                set
                {
                    if (value != null)
                        designation = value;
                    else
                        Console.WriteLine("Designation can not be blanck");
                }
                get
                {
                    return designation;
                }
            }

            public override decimal Basic
            {
                set
                {
                    basic = value;
                }
                get
                {
                    return basic;
                }
            }
            public Manager(string designation,string name, decimal basic, short deptno) : base(name,basic,deptno)
            {
				this.Designation = designation;
            }

        }

		public class GeneralManager : Manager
        {
			private string perks;

			public string Perks
            {
				set;
				get;
            }

			public GeneralManager(string perks, string designation, string name,decimal basic, short deptno) : base(designation,name, basic,deptno)
            {
				this.Perks = perks;
            }
				
		}

		public class CEO : Employee
        {
			public sealed override decimal CalcNetSalary()
			{
				decimal netsalary;
				netsalary = basic + 1000 + 1000 * 1000;
				return netsalary;
			}
			public override decimal Basic
			{
				set
				{
					basic = value;
				}
				get
				{
					return basic;
				}
			}
			public CEO(string name, decimal basic, short deptno) : base(name,basic,deptno)
			{ 
				
			}
		}
	}
}

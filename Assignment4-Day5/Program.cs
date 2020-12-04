using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Q1
{
	class Program
	{
		static void Main1(string[] args)
		{
            Console.WriteLine("Enter the details of Employee");
			Employee[] e = new Employee[5];
			for(int i = 0; i < e.Length ;  i++)
            {
                Console.Write("Name :");
				string name = Console.ReadLine();

				Console.Write("Basic :");
				decimal basic = Convert.ToDecimal(Console.ReadLine());

				Console.Write("Deptno :");
				short deptno = short.Parse(Console.ReadLine());

				Employee e1 = new Employee(name, basic, deptno);

				e[i] = e1;
			}

            Console.WriteLine("Enter empno you want the details of employee");
			int empid = Convert.ToInt32(Console.ReadLine());

			for(int j = 0; j < e.Length; j++)
            {
				if(empid == e[j].Empno)
                {
					e[j].Display();
                }	
            }

			decimal max = e[0].Basic;
			for(int k = 0; k < e.Length; k++)
            {
				if(max < e[k].Basic)
                {
					max = e[k].Basic;
                }
               
            }
			for (int i = 0; i < e.Length; i++)
			{
				if (e[i].Basic == max)
				{
					Console.WriteLine("Max Salary: " + e[i].Basic);
				}
			}


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
		public Employee(String name, decimal basic, short deptno)
		{
			this.name = name;
			this.basic = basic;
			this.deptno = deptno;
			auto++;
			this.empno = auto;
		}

		public void Display()
        {
			Console.WriteLine("Name: " + Name + " " + "Basic: " + Basic + " " + "Dept No: " + Deptno);
		}
	}

}


namespace Assignment4Q2
{
    class Program
    {
        static void Main2(string[] args)
        {

        }
    }
}



namespace Assignment4Q3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter the Details of Students :");
			Student[] s = new Student[5];
			for (int i = 0; i < s.Length; i++)
			{
				Console.Write("RollNo of Students :");
				int rollNo = Convert.ToInt32(Console.ReadLine());
				Console.Write("Name of Stud" +
					"ents :");
				string name = Console.ReadLine();
				Console.Write("Marks of Students :");
				decimal marks = Convert.ToDecimal(Console.ReadLine());

				Student s1 = new Student(rollNo, name, marks);
				s[i] = s1;
			}


			for (int i = 0; i < s.Length; i++)
			{
				s[i].Display();
			}


			Console.ReadLine();
		}

	}
}
	public struct Student
    {
		private String name;

		public string Name
        {
            set 
			{
				if (value != null)
					name = value;
				else
                    Console.WriteLine("name cannot be blank");
			}
			get
            {
				return name;
            }
        }

		private int rollNo;

		public int RollNo
		{
		set
		{
			if (value != 0)
					rollNo = value;
		}
		get
			{ 
				return rollNo;
			}
			
		}


		private decimal marks;
		public decimal Marks
		{
			get
			{
				return marks;
			}
			set
			{

				marks = value;

			}
		}

		public Student(int RollNo, string Name, decimal Marks) : this()
		{
			this.Marks = Marks;
			this.RollNo = RollNo;
			this.Name = Name;
		}

		public void Display()
		{
			Console.WriteLine("RollNo :" + RollNo + " " + "Name :" + Name + " " + "Marks :" + Marks);
		}


	}

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
            Console.WriteLine("Enter the Details of Employee");
            Employee[] e = new Employee[5];
            for (int i = 0; i < e.Length; i++)
            {
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Basic :");
                decimal basic = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Dept No :");
                short deptNo = short.Parse(Console.ReadLine());
                Employee e1 = new Employee(name, basic, deptNo);
                e[i] = e1;
            }

            Console.WriteLine("Enter EmpId you want the details of Employee");
            int empId = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < e.Length; i++)
            {
                if (empId == e[i].EmpNo)
                {
                   // Console.WriteLine(e[i]);
                    e[i].Display();
                }
            }
            decimal max = e[0].Basic;
            for(int i=0;i<e.Length;i++)
            {
                if(e[i].Basic > max)
                {
                    max = e[i].Basic;
                }
            }

            for(int i=0;i<e.Length;i++)
            {
                if(e[i].Basic==max)
                {
                    Console.WriteLine("Max Salary: "+ e[i].Basic);
                }
            }

            Console.ReadLine();
        }
    }
    public class Employee
    {
        private string name;
        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                    Console.WriteLine("Name should not be blank..!!");
            }
            get
            {
                return name;
            }
        }

        private static int auto;
        private int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                    Console.WriteLine("Dept No must be greater than 0");
            }
            get
            {
                return deptNo;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set;
            get;
        }

        public decimal GetNetSalary()
        {
            return basic + 1000 + 1000;
        }

        public Employee(string name, decimal basic, short deptno)
        {
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptno;
            auto++;
            this.empNo = auto;
        }

        public void Display()
        {
            Console.WriteLine("Name: "+ Name + " " +"Basic: "+ Basic + " " +"Dept No: "+ DeptNo);
        }


    }
}

namespace Assignment4Q2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.Write("Enter the number of batches: " );
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[n][];

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("Enter the number of students of batch {0}: ",i);
                int nos = Convert.ToInt32(Console.ReadLine());
                int[] marks = new int[nos];

                Console.Write("Enter the marks of students of batch {0}: ", i);
                for(int j=0;j<nos;j++)
                {
                    marks[j] = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = marks;
            }
            Console.WriteLine();
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write("Marks of student of batch {0} : ",i);
                    Console.WriteLine(arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

namespace Assignment4Q3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter the Details of Students :");
            Student[] s = new Student[5];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("RollNo of Students :");
                int rollNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name of Students :");
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

    struct Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                    Console.WriteLine("invalid name");
            }
        }


        private int rollNo;

        public int RollNo
        {
            get
            {

                return rollNo;
            }
            set
            {
                if (value != 0)
                {
                    rollNo = value;
                }
                else
                    Console.WriteLine("Invalid RollNo");

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
            Console.WriteLine("RollNo :"+RollNo + " " +"Name :"+ Name + " " +"Marks :"+ Marks);
        }
    }
}

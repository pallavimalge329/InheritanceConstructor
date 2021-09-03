using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructor
{

  class Employee
    {
        // member attributes
        public string EmployeeId;
        public string EmployeeName;
        public int age;
        public double weight;

        public Employee(string EmployeeId, string name, int age, double weight)
        {
            // to resolve the conflict 
            this.EmployeeId = EmployeeId;
            EmployeeName = name;
            this.age = age;
            this.weight = weight;
        }

        public void display()
        {
            Console.WriteLine("=========Employee Details==========");
            Console.WriteLine("Employee Id  : {0}", EmployeeId);
            Console.WriteLine("Employee Name  : {0}", EmployeeName);
            Console.WriteLine("Employee Age  : {0}", age);
            Console.WriteLine("Employee Weight  : {0}", weight);
        }

    }

    class Manager : Employee
    {
        int managerid;
        string designation;

        public Manager(string employeeid, String employeename, int age, double weight, int managerid, string designation)
                  : base(employeeid, employeename, age, weight)
        {
            this.managerid = managerid;
            this.designation = designation;
        }

        ~Manager() { }

        public void ManagerDetails()
        {
            // calling method of a base class
            base.display();

            // additional details
            Console.WriteLine("Manager id : {0}", managerid);
            Console.WriteLine("Designation : {0}", designation);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Demo!");
            // default constructor
            //Employee emp1 = new Employee("E001", "Abhishek", 24, 45.5F);


            Manager mgr1 = new Manager("E001", "Pallavi", 23, 47.5, 20, "Software developer");

            mgr1.ManagerDetails();
            Console.ReadKey();
        }

    }

}

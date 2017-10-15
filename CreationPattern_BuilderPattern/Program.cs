using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CreationPattern_BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Traditional Object Creational Sample");
            WriteLine("To construct an employee object I have to pass all parameters in constructor of empoyee object which is very complext to maintain");
            //var employee = new Employee("amruth", "Rayabagi", true, 10f, true);
            WriteLine("What if I need to add one more parameter to this!.. This violates the design and all clients get affected.");
            WriteLine("Instead build Employee object based on the builder pattern!");
            Employee builder = new FullTimeEmployeeBuilder().AddEmployeeStatus(true).
                                AddEmployeeType(true).
                                AddLastName("Rayabagi").
                                AddName("Amrut").
                                AddSalary(100).
                                GetEmployee();
            WriteLine(builder.ToString());
            ReadKey();
        }
    }

    public class Employee
    {
        string Name, LastName;
        bool isActiveEmployee, iFullTimeEmployee;
        double salary;

        public Employee(EmployeeBuilder builder)
        {
            this.Name = builder.name;
            this.LastName = builder.lastname;
            this.isActiveEmployee = builder.isActiveEmployee;
            this.iFullTimeEmployee = builder.iFullTimeEmployee;
            this.salary = builder.salary;
        }
        public override string ToString()
        {
            return $" Name : {this.Name} /n isActive {this.isActiveEmployee}";
        }
    }


    public interface EmployeeBuilder
    {
        bool iFullTimeEmployee { get; set; }
        bool isActiveEmployee { get; set; }
        string lastname { get; set; }
        string name { get; set; }
        double salary { get; set; }

        Employee GetEmployee();
    }

    public class FullTimeEmployeeBuilder : EmployeeBuilder
    {
        public bool iFullTimeEmployee
        { get; set; }

        public bool isActiveEmployee
        { get; set; }

        public string lastname
        { get; set; }

        public string name
        { get; set; }

        public double salary
        { get; set; }

        public Employee GetEmployee()
        {
            return new Employee(this);
        }

        public FullTimeEmployeeBuilder AddName(string name)
        {
            this.name = name;
            return this;
        }
        public FullTimeEmployeeBuilder AddSalary(double salary)
        {
            this.salary = salary;
            return this;
        }
        public FullTimeEmployeeBuilder AddLastName(string name)
        {
            this.lastname = name;
            return this;
        }
        public FullTimeEmployeeBuilder AddEmployeeType(bool isFullTime)
        {
            this.isActiveEmployee = isFullTime;
            return this;
        }
        public FullTimeEmployeeBuilder AddEmployeeStatus(bool isActive)
        {
            this.isActiveEmployee = isActive;
            return this;
        }
    }
}

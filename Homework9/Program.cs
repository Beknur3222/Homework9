using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Employee
    {
        protected string name;
        protected int age;
        protected decimal salary;

        public Employee(string name, int age, decimal salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:C}");
        }

        public virtual decimal CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }

    class Manager : Employee
    {
        private decimal bonus;

        public Manager(string name, int age, decimal salary, decimal bonus)
            : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Bonus: {bonus:C}");
        }

        public override decimal CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + bonus;
        }
    }

    class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, decimal salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Lines of Code per Day: {linesOfCodePerDay}");
        }

        public override decimal CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + (linesOfCodePerDay * 250); // 250 job day
        }
    }

    class Program
    {
        static void Main()
        {
            Manager manager = new Manager("Beknur Manager", 20, 60000, 5000);
            Developer developer = new Developer("Daryn Developer", 21, 70000, 100);

            Console.WriteLine("Manager Info:");
            manager.GetInfo();
            Console.WriteLine($"Year Salary: {manager.CalculateAnnualSalary():C}");

            Console.WriteLine("\nDeveloper Info:");
            developer.GetInfo();
            Console.WriteLine($"Year Salary: {developer.CalculateAnnualSalary():C}");

            Console.ReadKey();
        }
    }

}

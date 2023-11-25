using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09
{
    public class Employee
    {
        protected string name;
        protected int age;
        protected double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public virtual string GetInfo()
        {
            return $"Name: {name}, Age: {age}, Salary: {salary}";
        }

        public virtual double CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }
    public class Manager : Employee
    {
        private double bonus;

        public Manager(string name, int age, double salary, double bonus)
            : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        public override double CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + bonus;
        }
    }
    public class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {

            return base.CalculateAnnualSalary() + (linesOfCodePerDay * 0.5 * 250);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager("Donald MacTavish", 30, 5000, 2000);
            var developer = new Developer("Joseph Allen", 25, 4000, 100);

            Console.WriteLine(manager.GetInfo());
            Console.WriteLine($"Annual Salary (Manager): {manager.CalculateAnnualSalary()}");

            Console.WriteLine(developer.GetInfo());
            Console.WriteLine($"Annual Salary (Developer): {developer.CalculateAnnualSalary()}");
            Console.ReadKey();
        }
    }

}
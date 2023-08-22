/*
using System;
using System.Collections.Generic;

namespace Polymorphism
{
    //Step 2 - Contractor employee implementation / override
    class ContractorEmployee : Employee
    {
        // 6 - Overloading constructors
        public ContractorEmployee(string name):
             this(name, 1000)
        {}

        public ContractorEmployee(string name, double bonus) : 
            base(name, bonus)
        {}

        public override void Work()
        {
            Console.WriteLine("Contractor is working hard for the money!");
        }

        //Step 5a - overloading
        public override void Work(string exemptStatus)
        {
            Console.WriteLine("Contractors are " + exemptStatus);
        }

        public override void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            int salary = weeklyHours * wage;
            string result = weeklyHours + " hours worked. " + "Paid for " + weeklyHours
                                        + " hours (with overtime) at $" + wage + "/hr totaling $" + salary;
            Console.WriteLine(result);
            Console.WriteLine(" ");
        }
    }

    //Step 1 - Setup up base class / interface
    class Employee 
    {
        // Step 6 - Overloading constructors
        public string Name { get; set; }
        public double Bonus { get; set; }

        public Employee(string name) :
            this(name, 2000)
        {
        }

        public Employee(string name, double bonus)
        {
            Name = name;
            Bonus = bonus;
        }

        public virtual void Work()
        {
            Console.WriteLine("Permanent employee is hardly working!");
        }
        
        //Step 5b - overloading
        public virtual void Work(string exemptStatus)
        {
            Console.WriteLine("Permanent employees are " + exemptStatus);
        }

        public virtual void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            int salary = 40 * wage;
            string result = weeklyHours + " hours worked. " + "Paid for 40 hours (no overtime) at $"
                                        + wage + "/hr totaling $" + salary;
            Console.WriteLine(result);
            Console.WriteLine(" ");
        }

        // Step 3??
        public override string ToString()
        {
            return Name + " gets an annual bonus of $" + Bonus; // Add the bonus portion part of step 6
        }
    }
    
    //Step 4 - Setup a collection of employees, iterate loop & use polymorphism
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 50;
            int wage = 70;

            ContractorEmployee firstEmployee = new ContractorEmployee("Paul"); // You can use this to demo Allen's hiding of method
            Employee secondEmployee = new Employee("James");
            List<Employee> employees = new List<Employee>();

            employees.Add(firstEmployee);
            employees.Add(secondEmployee);

            foreach (Employee person in employees)
            {
                //Step 5c - overloading
                string employeeType = person is ContractorEmployee ? "Non-Exempt" : "Exempt";
                person.Work(employeeType);
                person.Work();
                person.DetermineWeeklySalary(hours, wage);
                Console.WriteLine(person.ToString());

            }
        }
    }
}

*/
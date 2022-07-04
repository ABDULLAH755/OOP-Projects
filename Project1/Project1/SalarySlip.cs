using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class SalarySlip
    {
        static void Main(string[] args)
        {
            String designation;
            Console.WriteLine("Hello");
            Console.WriteLine("Enter the designation: (engineer, manager, analyst)");

            designation = Console.ReadLine();
            if (designation == "manager")
            {
                Manager manager = new Manager();
                manager.GrossSalary();
            }

            else if(designation == "engineer")
            {
                Engineer engineer = new Engineer();
                engineer.GrossSalary();
            }

            else if(designation == "analyst")
            {
                Analyst analyst = new Analyst();
                analyst.GrossSalary();
            }

            else
            {
                Console.WriteLine("Designation not available");
            }
            


            Console.ReadLine();
        }
    }


    class Employee
    {
        protected int baseSalary = 1500;
        protected int grossSalary;
    }

    class Engineer : Employee
    {
        int fuelAndMedical = 100 + 500;
        public void GrossSalary()
        {
            grossSalary =  baseSalary + fuelAndMedical;
            Console.WriteLine("The Gross Salary is: " + grossSalary);
        }
    }
    class Manager : Employee
    {
        int fuelAndMedical = 250 + 1000;
        public void GrossSalary()
        {
            grossSalary = baseSalary + fuelAndMedical;
            Console.WriteLine("The Gross Salary is: " + grossSalary);
        }
    }

    class Analyst : Employee
    {
        int fuelAndMedical = 150 + 800;
        public void GrossSalary()
        {
            grossSalary = baseSalary + fuelAndMedical;
            Console.WriteLine("The Gross Salary is: " + grossSalary);
        }
    }
}

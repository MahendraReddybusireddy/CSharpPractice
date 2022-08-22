using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee[] employees = new Employee[3];


            //Employee employee1 = new Employee();
            //employee1.FirstName = "Alex";
            //employee1.LastName = "Hales";
            //employee1.Gender = "Male";
            //employee1.Salary = 123.678;
            //employee1.Age = 27;

            //employees[0] = employee1;

            //Employee employee2 = new Employee();
            //employee2.FirstName = "Alex";
            //employee2.LastName = "Hales";
            //employee2.Gender = "Male";
            //employee2.Salary = 123.678;
            //employee2.Age = 27;

            //employees[1] = employee2;

            //Employee employee3 = new Employee();
            //employee1.FirstName = "Alex";
            //employee1.LastName = "Hales";
            //employee1.Gender = "Male";
            //employee1.Salary = 123.678;
            //employee1.Age = 27;

            //employees[2] = employee3;

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine($"Employee FirstName : {employee.FirstName}");
            //}
            Console.Write("Plese enter numer of employees to be added to DataBase :");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            Employee[]employees = new Employee[numberOfEmployees];  
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Enter Employee{i + 1}details: ");
                Console.Write("FirstName :");
                string fname = Console.ReadLine().Trim();
                Console.Write("Last Name : ");
                string lname = Console.ReadLine().Trim();
                Console.Write("Gender :");
                string gender = Console.ReadLine().Trim();
                Console.Write("Salary :");
                double salary = Convert.ToDouble(Console.ReadLine().Trim());
                Console.Write("Age :");
                int age = Convert.ToInt32(Console.ReadLine().Trim());  
                Employee employee  = new Employee();
                employee.FirstName = fname;
                employee.LastName  = lname;
                employee.Gender    = gender;
                employee.Salary    = salary;
                employee.Age       = age;
                employees[i] = employee;
            }
            Console.ReadLine();
        }
    }
}

           
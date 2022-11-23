﻿using System;
using Classes; 


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
               Company target = new Company("Target", DateTime.Now ); 
            // Create three employees
                Employee jane = new Employee("Jane", "Doe", "Cashier", new DateTime()); 

                 Employee john = new Employee( "John", "Doe","Custodian", new DateTime());
                
                 Employee joe = new Employee("Joe", "Dirt", "Manager", new DateTime());
            
            // Assign the employees to the company
           List<Employee> employees = new List<Employee>();
            employees.Add(jane);
            employees.Add(john);
            employees.Add(joe);
 
            foreach (Employee employee in employees)
            {
                target.Employees.Add(employee);
                target.ListEmployees(employee);

            }  
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}

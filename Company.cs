using System;
using System.Collections.Generic;
using Classes; 

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        
       
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string companyName, DateTime createdOn) 
        {
            Name = companyName; 
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

      public void ListEmployees(Employee employee) 
        {
            
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as a {employee.Title} since {employee.StartDate}");
        
            
        } 
        
    
    }   
}





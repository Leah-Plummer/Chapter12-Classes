using System;

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

       
    }

    
}

/*

public class Customer
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public bool IsLocal { get; set; }

    // Calculated property that has no setter. It is readonly.
    public string FullName 
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}

*/


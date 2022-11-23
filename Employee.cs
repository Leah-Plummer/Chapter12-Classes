namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string firstName, string lastname, string title, DateTime startDate)
        {
            FirstName = firstName; 
            LastName = lastname; 
            Title = title; 
            StartDate = startDate; 
        }

    }
}
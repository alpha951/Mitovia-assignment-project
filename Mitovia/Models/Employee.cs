namespace Mitovia.Models
{
    public class Employee
    {
        public Guid Id { get; set; }  // Guid is a unique identifier globally
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }

        public string Department { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}

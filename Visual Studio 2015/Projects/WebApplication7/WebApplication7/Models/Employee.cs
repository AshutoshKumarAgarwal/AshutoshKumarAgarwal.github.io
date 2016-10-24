using PetaPoco;

namespace WebApplication7.Models
{
    [TableName("Employee")]
    [PrimaryKey("EmployeeId")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
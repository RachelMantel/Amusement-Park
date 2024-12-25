using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace AmusementPark.Core.Entities
{
    [Table("Employees")]
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }

        public string Tz { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Role { get; set; }

        public int Seniority { get; set; }

        public double Salary { get; set; }

        public int WorkingHours { get; set; }

        public bool Status { get; set; }

        //one-to-many
        public int? facilitieId { get; set; }
        public FacilitieEntity? facilitie { get; set; }

        public EmployeeEntity()
        {
            
        }
        public void Copy(EmployeeEntity e)
        {
            Id= e.Id;
            Tz = e.Tz;
            Name = e.Name;
            Email = e.Email;
            Phone = e.Phone;
            Role = e.Role;
            Seniority = e.Seniority;
            Salary = e.Salary;
            WorkingHours = e.WorkingHours;
            Status = e.Status;
        }

        //public EmployeeEntity(int id,string tz, string name, string email, string phone, string role, int seniority, double salary, int workingHours, bool status)
        //{
        //    Id = id;
        //    Tz = tz;
        //    Name = name;
        //    Email = email;
        //    Phone = phone;
        //    Role = role;
        //    Seniority = seniority;
        //    Salary = salary;
        //    WorkingHours = workingHours;
        //    Status = status;
        //}
    }
}

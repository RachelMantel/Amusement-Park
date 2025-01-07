
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace AmusementPark.Core.Entities
{
    [Table("Customers")]
    public class CustomerEntity
    {
        [Key]
        public int Id { get; set; }

        public string Tz{ get; set; }

        public string Name{get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public DateTime DateRegistration { get; set; }

        public int Points { get; set; }

        public string CustomerType { get; set; }
        public List<OrderEntity> Orders { get; set; }
        public CustomerEntity()
        {
            
        }
        public void Copy(CustomerEntity c)
        {
            Id = c.Id;
            Tz = c.Tz;
            Name = c.Name;
            Email = c.Email;
            Phone = c.Phone;
            Password = c.Password;
            DateRegistration = c.DateRegistration;
            Points = c.Points;
            CustomerType = c.CustomerType;
        }
        //public CustomerEntity(int id,string tz, string name, string email, string phone, string password, DateTime dateRegistration, int points, string customerType)
        //{
        //    Id = id;
        //    Tz = tz;
        //    Name = name;
        //    Email = email;
        //    Phone = phone;
        //    Password = password;
        //    DateRegistration = dateRegistration;
        //    Points = points;
        //    CustomerType = customerType;
        //}
    }
}


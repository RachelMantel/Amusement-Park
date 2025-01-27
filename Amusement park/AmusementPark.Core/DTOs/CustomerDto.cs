using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Tz { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public DateTime DateRegistration { get; set; }

        public int Points { get; set; }

        public string CustomerType { get; set; }
    }
}

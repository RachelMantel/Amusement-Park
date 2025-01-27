using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.DTOs
{
    public class FacilitieDto
    {
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

        
        public int? facilitieId { get; set; }
    }
}

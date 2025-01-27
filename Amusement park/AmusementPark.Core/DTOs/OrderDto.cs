using AmusementPark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int FinallPrice { get; set; }

        public string PaymentMethod { get; set; }

        public int Quantity { get; set; }
    }
}

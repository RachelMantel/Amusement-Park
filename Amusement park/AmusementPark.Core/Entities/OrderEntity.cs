
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmusementPark.Core.Entities
{
    [Table("Orders")]
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }

        //one to one
        public int TicketId { get; set; }
        public TicketEntity ticket { get; set; }


     //one-to-many
        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public int FinallPrice { get; set; }

        public string PaymentMethod { get; set; }

        public int Quantity { get; set; }

        public OrderEntity()
        {
            
        }
        public void Copy(OrderEntity o)
        {
            Id = o.Id;
            TicketId = o.TicketId;
            CustomerId = o.CustomerId;
            OrderDate = o.OrderDate;
            FinallPrice = o.FinallPrice;
            PaymentMethod = o.PaymentMethod;
            Quantity = o.Quantity;
        }

        //public OrderEntity(int id,int ticketId, int customerId, DateTime orderDate, int finallPrice, string paymentMethod, int quantity)
        //{
        //    Id = id;
        //    TicketId = ticketId;
        //    CustomerId = customerId;
        //    OrderDate = orderDate;
        //    FinallPrice = finallPrice;
        //    PaymentMethod = paymentMethod;
        //    Quantity = quantity;
        //}
    }
}

namespace AmusementPark.Api.PostModels
{
    public class OrderPostModel
    {
        public int TicketId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int FinallPrice { get; set; }

        public string PaymentMethod { get; set; }

        public int Quantity { get; set; }
    }
}

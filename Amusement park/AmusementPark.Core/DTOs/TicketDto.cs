namespace AmusementPark.Core.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public string Sort { get; set; }

        public int Price { get; set; }

        public DateTime Validity { get; set; }

    }
}

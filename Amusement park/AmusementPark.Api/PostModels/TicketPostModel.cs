namespace AmusementPark.Api.PostModels
{
    public class TicketPostModel
    {
        public DateTime DateOfPurchase { get; set; }

        public string Sort { get; set; }

        public int Price { get; set; }

        public DateTime Validity { get; set; }

    }
}

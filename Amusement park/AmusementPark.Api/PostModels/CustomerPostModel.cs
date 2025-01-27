namespace AmusementPark.Api.PostModels
{
    public class CustomerPostModel
    {
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

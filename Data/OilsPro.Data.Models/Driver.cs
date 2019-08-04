namespace OilsPro.Data.Models
{
    public class Driver
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string CarrierId { get; set; }
        public Carrier Carrier { get; set; }
    }
}

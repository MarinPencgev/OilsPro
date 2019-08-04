namespace OilsPro.Data.Models
{
    public class Lot
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public int PackagesCount { get; set; }
        public decimal PackagesWeight{ get; set; }
        public decimal Density { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
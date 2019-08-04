namespace OilsPro.Data.Models
{
    public class OrderedProducts
    {
        public string OrderId { get; set; }
        public Order Order { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderedPackagesCount { get; set; }

        public decimal OrderedPackagesWeight { get; set; }
    }
}

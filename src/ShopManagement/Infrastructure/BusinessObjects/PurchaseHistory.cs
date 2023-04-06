namespace Infrastructure.BusinessObjects
{
    public class PurchaseHistory
    {
        public int Id { get; set; }
        public ProductDetail Product { get; set; }
        public int ProductDetailId { get; set; }
        public int TotalPurchase { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public Shopkeeper LastPurchaseSupplier { get; set; }
        public int TotalSales { get; set; }
        public DateTime LastSaleDate { get; set; }
        public Customer LastSaleCustomer { get; set; }
    }
}

namespace Infrastructure.Entities
{
    public class ProductDetail : IEntity<int>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CatagoryId { get; set; }
        public int UnitId { get; set; }
        public List<string> WarehouseList { get; set; }
        public int Stock { get; set; }
        public int TotalPurchase { get; set; }
        public DateOnly LastPurchaseDate { get; set; }
        public string LastPurchaseSupplier { get; set; }
        public int TotalSales { get; set; }
        public DateOnly LastSaleDate { get; set; }
        public string LastSaleCustomer { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
    }
}

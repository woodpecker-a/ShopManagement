namespace Infrastructure.Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public int ProductCode { get; set; }
        public int ParentCode { get; set; }
        public int ProductBarCode { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public int ProductDetailId { get; set; }
        public Pricing Price { get; set; }
        public int PriceId { get; set; }
        public List<ProductWarehouse> WarehouseList { get; set; }
        public bool Status { get; set; }
    }
}

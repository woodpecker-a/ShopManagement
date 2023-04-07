namespace Infrastructure.BusinessObjects
{
    public class ProductWarehouse
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public WareHouse Warehouse { get; set; }
        public int WarehouseId { get; set; }
        public int Stock { get; set; }
    }
}

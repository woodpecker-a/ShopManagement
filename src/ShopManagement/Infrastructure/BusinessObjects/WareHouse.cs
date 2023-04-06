namespace Infrastructure.BusinessObjects
{
    public class WareHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductWarehouse> Products { get; set; }
    }
}

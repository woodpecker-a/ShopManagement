namespace Infrastructure.Entities
{
    public class WareHouse : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductWarehouse> Products { get; set; }
    }
}

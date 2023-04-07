namespace Infrastructure.Entities
{
    public class Pricing : IEntity<int>
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
        public int CostPrice { get; set; }
    }
}

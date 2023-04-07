namespace Infrastructure.Entities
{
    public class Brand : IEntity<int>
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}

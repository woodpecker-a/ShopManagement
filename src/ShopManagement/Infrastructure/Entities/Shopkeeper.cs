namespace Infrastructure.Entities
{
    public class Shopkeeper : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

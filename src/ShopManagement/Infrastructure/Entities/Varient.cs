namespace Infrastructure.Entities
{
    public class Varient : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

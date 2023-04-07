namespace Infrastructure.Entities
{
    public class Size : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

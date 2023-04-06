namespace Infrastructure.Entities
{
    public class Unit : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

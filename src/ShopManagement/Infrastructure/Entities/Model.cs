namespace Infrastructure.Entities
{
    public class Model : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

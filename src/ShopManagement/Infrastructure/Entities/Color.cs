namespace Infrastructure.Entities
{
    public class Color : IEntity<int>
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}

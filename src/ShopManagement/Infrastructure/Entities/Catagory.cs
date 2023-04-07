namespace Infrastructure.Entities
{
    public class Catagory : IEntity<int>
    {
        public int Id { get; set; }
        public string CatagoryName { get; set; }
    }
}

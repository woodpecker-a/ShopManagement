namespace Infrastructure.Entities
{
    public class ProductDetail : IEntity<int>
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public Size Size { get; set; }
        public int SizeId { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public Varient Varient { get; set; }
        public int VarientId { get; set; }
        public PurchaseHistory PurchaseHistory { get; set; }
        public int PurchaseHistoryId { get; set; }
        public string ImagePath { get; set; }
        public string Type { get; set; }
    }
}

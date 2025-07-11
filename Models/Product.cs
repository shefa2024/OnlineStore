namespace Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public double Rating { get; set; }
    }
}

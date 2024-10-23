namespace PhoneApp.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; } = null!;
        public List<Category> Categories { get; set; }
        public string? SelectedCategory { get; set; }
    }
}

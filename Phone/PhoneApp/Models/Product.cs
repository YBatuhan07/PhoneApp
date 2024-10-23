using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }
        [Display(Name = "Model")]
        [Required(ErrorMessage ="Yanlış isim bilgisi")]
        [StringLength(25, ErrorMessage = "{0} Karakter sayısı {2} ile {1} arasında olmalıdır.", MinimumLength = 5)]
        public string Name { get; set; }
        [Display(Name = "Fiyat")]
        [Range(0,500000)]
        public decimal Price { get; set; }
        [Display(Name = "Görsel")]
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}

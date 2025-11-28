using System.ComponentModel.DataAnnotations;

namespace CoreWebApiApp.DTOs
{
    public class ProductUpdateDTO
    {
        [Required (ErrorMessage ="Product Id is required.")]
        public int Id { get; set; }
        [Required (ErrorMessage = "Prodcut name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="Product name should be between 3 and 100 characters.")]
        public string Name { get; set; }

        [Range(0.01, 10000.00, ErrorMessage = "Product price must be between 0.01 and 10000.00")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category Id is required.")]
        public int CategoryId { get; set; }
    }
}

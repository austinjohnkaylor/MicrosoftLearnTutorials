using System.ComponentModel.DataAnnotations;

namespace ContosoPets.Api.Models
{
    public class Product
    {
        public long Id { get; set; }

        [Required] // to ensure values are provided when creating a Product object
        public string Name { get; set; }

        [Required] // to ensure values are provided when creating a Product object
        [Range(minimum: 0.01, maximum: (double) decimal.MaxValue)]
        public decimal Price { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Store_Unit2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a desciption.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        public double Price { get; set; }


        [Required(ErrorMessage = "Please enter a image.")]
        public string ImagePath { get; set; } 

    }
}

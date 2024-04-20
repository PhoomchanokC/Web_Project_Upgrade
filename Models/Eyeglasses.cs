using System.ComponentModel.DataAnnotations;
namespace DotNet.Models
{
    public class Eyeglasses
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Color { get; set; }

      
    }
}
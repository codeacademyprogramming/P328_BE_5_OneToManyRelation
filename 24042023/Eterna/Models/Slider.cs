using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title1 { get; set; }
        [MaxLength(35)]
        public string Title2 { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(100)]
        public string BgImg { get; set; }
        [MaxLength(250)]
        public string  BtnUrl { get; set; }
        [MaxLength(35)]
        public string BtnText { get; set; }
        public int Order { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        [Required]
        [MaxLength(35)]
        public string FullName { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        [MaxLength(250)]
        public string FbUrl { get; set; }
        [MaxLength(250)]
        public string InstaUrl { get; set; }
        [MaxLength(250)]
        public string LinkedinUrl { get; set; }
        [MaxLength(250)]
        public string TwitterUrl { get; set; }

        public Position Position { get; set; }

    }
}

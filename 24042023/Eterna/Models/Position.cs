using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public List<TeamMember> TeamMembers { get; set; }
    }
}

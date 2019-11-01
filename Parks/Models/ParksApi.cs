using System.ComponentModel.DataAnnotations;
namespace Parks.Models
{
    public class Park
    {
        public int ParkId {get; set; }
        [Required]
        [StringLength (20)]
        public string Name {get; set; }

        public string Land {get; set; }

        public string State {get; set; }
    }
}
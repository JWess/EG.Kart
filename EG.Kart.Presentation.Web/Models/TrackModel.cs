using System.ComponentModel.DataAnnotations;

namespace EG.Kart.Presentation.Web.Models
{
    public class TrackModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
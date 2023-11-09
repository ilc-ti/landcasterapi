using System.ComponentModel.DataAnnotations;

namespace LandCasterApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string body { get; set; }
        public DateTime date { get; set; }

    }
}

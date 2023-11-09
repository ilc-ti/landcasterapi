
using System.ComponentModel.DataAnnotations;

namespace LandCasterApi.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public long Telephone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}

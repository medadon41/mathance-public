using Mathance.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace Mathance.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public string Data { get; set; }

        [Required]
        public Post Post { get; set; }
    }
}

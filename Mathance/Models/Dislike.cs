using Mathance.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace Mathance.Models
{
    public class Dislike
    {
        [Key]
        public int Id { get; set; }

        public MathanceUser User { get; set; }

        public Comment Comment { get; set; }
    }
}

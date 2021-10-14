using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mathance.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string Link { get; set; }

        public Post Post { get; set; }
    }
}

using Mathance.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mathance.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public MathanceUser Author { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Post Post { get; set; }

        [Required]
        public DateTime PostedTime { get; set; }

        public List<Like> Likes { get; set; }

        public List<Dislike> Dislikes { get; set; }

    }
}

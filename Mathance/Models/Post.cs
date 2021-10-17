using Mathance.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mathance.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public MathanceUser Author { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Topic { get; set; }

        [Required]
        public int Rating { get; set; }

        public DateTime PostedDate { get; set; }

        public List<Tag> Tags { get; set; }

        public List<Image> Images { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Answer> RightAnswers { get; set; }
    }
}

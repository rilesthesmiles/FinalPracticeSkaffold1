using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalPracticeSkaffold1.Models
{
    public class Responses
    {
        [Key]
        [Required]
        public long MovieForumId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        public long Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}

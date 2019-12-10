using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models {
    public class Quote {
        [Required]
        [MinLength (2)]
        public string Name { get; set; }

        [Required]
        [MinLength (5)]
        public string Content { get; set; }
    }
}
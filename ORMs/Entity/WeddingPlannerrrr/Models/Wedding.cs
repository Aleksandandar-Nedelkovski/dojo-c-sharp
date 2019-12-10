using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models {
    public class Wedding {
        [Key]
        public int WeddingID { get; set; }

        [Required (ErrorMessage = "It takes two people to get married")]
        [Display (Name = "Wedder One: ")]
        public string WedderOne { get; set; }

        [Required (ErrorMessage = "Come on, you lonely hearts!")]
        [Display (Name = "Wedder Two: ")]
        public string WedderTwo { get; set; }

        [Required (ErrorMessage = "When's the freakin wedding")]
        [DataType (DataType.Date)]
        [Display (Name = "Date: ")]
        public DateTime When { get; set; }

        [Required (ErrorMessage = "Where's the venue?")]
        [Display (Name = "Venue Address: ")]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<RSVP> RSVPs { get; set; }

        public int CreatorID { get; set; }

    }
}
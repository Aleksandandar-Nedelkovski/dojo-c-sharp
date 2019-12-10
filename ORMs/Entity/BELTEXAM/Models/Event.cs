using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BELTEXAM.Models;

namespace BELTEXAM.Models {
    public class Event {
        [Key]
        public int ID { get; set; }

        [Required (ErrorMessage = "Please name your Event")]
        [MinLength (2, ErrorMessage = "Go on, give your event a real name")]
        [Display (Name = "Title: ")]
        public string Title { get; set; }

        [Required (ErrorMessage = "When is your Event?")]

        [Display (Name = "Date: ")]
        public DateTime? DateOfEvent { get; set; }

        [Required (ErrorMessage = "What time is your event?")]

        [Display (Name = "Time: ")]
        public DateTime? Time { get; set; }

        [Required (ErrorMessage = "How long will your event last?")]
        [Display (Name = "Duration: ")]
        public int? Duration { get; set; }

        [Required (ErrorMessage = "Is that in hours, or minutes, or what?")]
        [Display (Name = "Duration (cont): ")]
        public string DurationUnit { get; set; }

        [Required (ErrorMessage = "Please describe your Event")]
        [MinLength (10, ErrorMessage = "Descriptions are best when at least 10 characters long")]
        [Display (Name = "Description: ")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Participant> Participants { get; set; }
        public int CoordinatorID { get; set; }
        public User Coordinator { get; set; }
    }
}
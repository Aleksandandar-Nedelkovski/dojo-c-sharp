using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models {
    public class RSVP {
        [Key]
        public int RSVP_ID { get; set; }
        public int UserID { get; set; }
        public int WeddingID { get; set; }
        public Wedding Wedding { get; set; }
        public User User { get; set; }
    }
}
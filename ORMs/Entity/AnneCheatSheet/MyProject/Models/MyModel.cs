using System;
using System.ComponentModel.DataAnnotations;
namespace MyProject.Models {
    public class MyModel {
        [Key]
        public int Id { get; set; }
        public string Data { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
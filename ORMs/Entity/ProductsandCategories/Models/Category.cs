using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsandCategories.Models {
    public class Category {
        [Key]
        public int CategoryId { get; set; }

        [Required (ErrorMessage = "Category name is required.")]
        [MinLength (2, ErrorMessage = "Category name must be at least 2 characters.")]
        [Display (Name = "Category Name:")]
        public string Name { get; set; }
        public List<Association> AssociatedProducts { get; set; } = new List<Association> ();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
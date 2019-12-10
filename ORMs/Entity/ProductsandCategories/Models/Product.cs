using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsandCategories.Models {
    public class Product {
        [Key]
        public int ProductId { get; set; }

        [Required (ErrorMessage = "Name is required.")]
        [MinLength (2, ErrorMessage = "Name must be at least 2 characters.")]
        [Display (Name = "Product Name:")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Description is required.")]
        [MinLength (10, ErrorMessage = "Description must be at least 10 characters.")]
        [Display (Name = "Description:")]
        public string Description { get; set; }

        [Required (ErrorMessage = "Price is required.")]
        [Display (Name = "Price:")]
        [Range (0.01, 10000.00)]
        public decimal Price { get; set; }
        public string PriceString { get; set; }
        public List<Association> AssociatedCategories { get; set; } = new List<Association> ();

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
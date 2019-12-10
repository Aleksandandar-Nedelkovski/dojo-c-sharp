using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsandCategories.Models;

namespace ProductsandCategories.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index () {
            return RedirectToAction ("Products");
        }

        [HttpGet ("products")]
        public IActionResult Products () {
            List<Product> allProducts = dbContext.Products.ToList ();
            ViewBag.AllProducts = allProducts;
            return View ("Products");
        }

        [HttpGet ("categories")]
        public IActionResult Categories () {
            List<Category> allCategories = dbContext.Categories.ToList ();
            ViewBag.AllCategories = allCategories;
            return View ("Categories");
        }

        [HttpPost ("createproduct")]
        public IActionResult CreateProduct (Product newProduct) {
            if (ModelState.IsValid) {
                newProduct.PriceString = newProduct.Price.ToString ("$0.00");
                dbContext.Products.Add (newProduct);
                dbContext.SaveChanges ();
                return RedirectToAction ("ShowProduct", new { Id = newProduct.ProductId });
            }
            List<Product> allProducts = dbContext.Products.ToList ();
            ViewBag.AllProducts = allProducts;
            return View ("Products");
        }

        [HttpGet ("products/{Id}")]
        public IActionResult ShowProduct (int Id) {
            Product retrievedProduct = GetCompleteProduct (Id);
            List<Category> UnassociatedCategories = GetUnassociatedCategories (Id);
            ViewBag.UnassociatedCategories = UnassociatedCategories;
            return View ("ShowProduct", retrievedProduct);
        }
        public Product GetCompleteProduct (int Id) {
            Product retrievedProduct = dbContext.Products
                .Include (prod => prod.AssociatedCategories)
                .ThenInclude (assoc => assoc.Category)
                .FirstOrDefault (prod => prod.ProductId == Id);
            HttpContext.Session.SetInt32 ("ProductId", Id);
            return retrievedProduct;
        }
        public List<Category> GetUnassociatedCategories (int Id) {
            List<Category> UnassociatedCategories = dbContext.Categories
                .Include (c => c.AssociatedProducts)
                .Where (c => c.AssociatedProducts
                    .All (a => a.ProductId != Id)).ToList ();
            return UnassociatedCategories;
        }

        [HttpPost ("createcategory")]
        public IActionResult CreateCategory (Category newCategory) {
            if (ModelState.IsValid) {
                dbContext.Categories.Add (newCategory);
                dbContext.SaveChanges ();
                return RedirectToAction ("ShowCategory", new { Id = newCategory.CategoryId });
            }
            List<Category> allCategories = dbContext.Categories.ToList ();
            ViewBag.AllCategories = allCategories;
            return View ("Categories");
        }

        [HttpGet ("categories/{Id}")]
        public IActionResult ShowCategory (int Id) {
            Category retrievedCategory = GetCompleteCategory (Id);
            List<Product> UnassociatedProducts = GetUnassociatedProducts (Id);
            ViewBag.UnassociatedProducts = UnassociatedProducts;
            return View ("ShowCategory", retrievedCategory);
        }

        public List<Product> GetUnassociatedProducts (int Id) {
            List<Product> UnassociatedProducts = dbContext.Products
                .Include (c => c.AssociatedCategories)
                .Where (c => c.AssociatedCategories
                    .All (a => a.CategoryId != Id)).ToList ();
            return UnassociatedProducts;
        }

        public Category GetCompleteCategory (int Id) {
            Category retrievedCategory = dbContext.Categories
                .Include (cat => cat.AssociatedProducts)
                .ThenInclude (assoc => assoc.Product)
                .FirstOrDefault (cat => cat.CategoryId == Id);
            HttpContext.Session.SetInt32 ("CategoryId", Id);
            return retrievedCategory;
        }

        [HttpPost ("addcategory")]
        public IActionResult AddCategory (int Id) {
            if (Id == 0) {
                TempData["alertMessage"] = "<p style='color:red;'>Please choose a category.</p>";
                return RedirectToAction ("ShowProduct", new { Id = HttpContext.Session.GetInt32 ("ProductId") });
            }
            Category retrievedCategory = dbContext.Categories
                .FirstOrDefault (c => c.CategoryId == Id);
            Product currentProduct = dbContext.Products
                .FirstOrDefault (p => p.ProductId == HttpContext.Session.GetInt32 ("ProductId"));
            Association newAssociation = new Association ();
            newAssociation.CategoryId = retrievedCategory.CategoryId;
            newAssociation.ProductId = currentProduct.ProductId;
            newAssociation.Category = retrievedCategory;
            newAssociation.Product = currentProduct;
            dbContext.Associations.Add (newAssociation);
            dbContext.SaveChanges ();
            return RedirectToAction ("ShowProduct", new { Id = currentProduct.ProductId });
        }

        [HttpPost]
        [Route ("addproduct")]
        public IActionResult AddProduct (int Id) {
            if (Id == 0) {
                TempData["alertMessage"] = "<p style='color:red;'>Please choose a product.</p>";
                return RedirectToAction ("ShowCategory", new { Id = HttpContext.Session.GetInt32 ("CategoryId") });
            }
            Product retrievedProduct = dbContext.Products
                .FirstOrDefault (p => p.ProductId == Id);
            Category currentCategory = dbContext.Categories
                .FirstOrDefault (c => c.CategoryId == HttpContext.Session.GetInt32 ("CategoryId"));
            Association newAssociation = new Association ();
            newAssociation.CategoryId = retrievedProduct.ProductId;
            newAssociation.ProductId = currentCategory.CategoryId;
            newAssociation.Product = retrievedProduct;
            newAssociation.Category = currentCategory;
            dbContext.Associations.Add (newAssociation);
            dbContext.SaveChanges ();
            return RedirectToAction ("ShowCategory", new { Id = currentCategory.CategoryId });
        }

    }
}
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
    public class CRUDcontext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public CRUDcontext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
    }
}
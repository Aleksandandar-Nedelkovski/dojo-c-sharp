using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Models {
    public class BankAccountsContext : DbContext {
        public BankAccountsContext(DbContextOptions<BankAccountsContext> options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
    }
}
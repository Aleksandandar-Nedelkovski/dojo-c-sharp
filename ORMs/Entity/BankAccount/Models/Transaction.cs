using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.Models {
    public class Transaction {
        [Key]
        public int TransactionId { get; set; }
        public int UserId { get; set; }

        [Display (Name = "Deposit/Withdraw:")]
        public double Amount { get; set; }
        public string AmountString { get; set; }
        public User AccountHolder { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtString { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models {
    public class Transaction {

        [Key]
        public int Id {get;set;}
        public int UserId {get;set;}

        [Display(Name = "Deposit/Withdraw:")]
        public double Amount {get;set;}
        public string AmountString {get;set;}
        public User AccountHolder {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public string CreatedAtString {get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.Models {
    public class UsersAndTransactions {

        public User newUser { get; set; }
        public Transaction newTransaction { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackendApp.Models
{
    public class Account
{
    public int Id { get; set; }
    public required string Name { get; set; } // e.g., "Checking Account"
    public required string Type { get; set; } // e.g., "Savings", "Credit Card"
    public decimal Balance { get; set; }
    public int UserId { get; set; } 
    public required User User { get; set; } // Relationship with User
    public required List<Transaction> Transactions { get; set; } // Relationship with Transactions
}

}
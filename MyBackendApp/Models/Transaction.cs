using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBackendApp.Enums;

namespace MyBackendApp.Models
{
    public class Transaction
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public TransactionType Type { get; set; } // Enum: Expense, Income
    public int AccountId { get; set; } 
    public required Account Account { get; set; } // Relationship with Account
    public int? CategoryId { get; set; } // Optional category
    public required Category Category { get; set; } 
}

}
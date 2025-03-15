using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackendApp.Models
{
    public class Budget
{
    public int Id { get; set; }
    public int UserId { get; set; } 
    public required User User { get; set; }
    public int CategoryId { get; set; }
    public required Category Category { get; set; }
    public decimal Limit { get; set; } // e.g., $500 monthly budget for groceries
    public decimal Spent { get; set; } // Current spending
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

}
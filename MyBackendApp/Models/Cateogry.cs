using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackendApp.Models
{
public class Cateogry
{
    public int Id { get; set; }
    public required string Name { get; set; } // e.g., "Groceries", "Rent", "Salary"
    public int UserId { get; set; }
    public required User User { get; set; } // Categories are user-specific

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackendApp.Models
{
public class Goal
{
    public int Id { get; set; }
    public required string Name { get; set; } // e.g., "Emergency Fund"
    public decimal TargetAmount { get; set; }
    public decimal CurrentAmount { get; set; }
    public DateTime TargetDate { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
}

}
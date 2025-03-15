using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackendApp.Models
{
    public class User 
  {
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; } // Securely stored
    public DateTime CreatedAt { get; set; }
    public required List<Account> Accounts { get; set; } // Relationship with financial accounts
}

}
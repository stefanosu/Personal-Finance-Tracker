using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackendApp.Models
{
    public class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
    public required string Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
}

}
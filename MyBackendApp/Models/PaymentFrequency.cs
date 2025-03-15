using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBackendApp.Enums;

namespace MyBackendApp.Models
{
public class RecurringPayment
{
    public int Id { get; set; }
    public required string Name { get; set; } // e.g., "Netflix Subscription"
    public decimal Amount { get; set; }
    public DateTime NextPaymentDate { get; set; }
    public PaymentFrequency Frequency { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
}

}
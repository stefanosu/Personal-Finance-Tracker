using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBackendApp.Controllers
{
    public class TransactionsController : BaseController
    {
        [HttpGet]
        public IActionResult GetTransactions()
        {
            var transactions = new[]
            {
                new { Id = 1, Amount = 100.50, Category = "Groceries" },
                new { Id = 2, Amount = 200.00, Category = "Rent" }
            };

            return Success(transactions, "Transactions retrieved successfully");
        }

        [HttpPost]
        public IActionResult AddTransaction([FromBody] object transaction)
        {
            if (transaction == null)
                return Error("Invalid transaction data");

            return Success(transaction, "Transaction added successfully");
        }
    }
}

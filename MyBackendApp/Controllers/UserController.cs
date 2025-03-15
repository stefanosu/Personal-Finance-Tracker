using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBackendApp.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Id = 1, Name = "Michael" },
                new { Id = 2, Name = "Stefan" }, 
                new { Id = 3, Name = "Bear" }
            };

            return Success(users, "Users retrieved successfully");
        }
    }
}
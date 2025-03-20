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
                new { Id = 1, FirstName = "Michael", LastName = "Fulton" , Email= "FrenchFultonjr@gmail.com", PasswordHash= "", },
                new { Id = 1, FirstName = "Barry", LastName = "G" , Email= "bereket.ghebremedhin92@gmail.com", PasswordHash= "", },
                new { Id = 1, FirstName = "Stefanos", LastName = "Ugbit" , Email= "stefanos.ugbit@gmail.com", PasswordHash= "", },
            };

            return Success(users, "Users retrieved successfully");
        }
    }
}
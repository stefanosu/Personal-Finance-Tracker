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
                new { Id = 1, FirstName = "Michael", LastName = "" , Email= "", PasswordHash= "", },
                new { Id = 1, FirstName = "Michael", LastName = "" , Email= "", PasswordHash= "", },
                new { Id = 1, FirstName = "Michael", LastName = "" , Email= "", PasswordHash= "", },
            };

            return Success(users, "Users retrieved successfully");
        }
    }
}
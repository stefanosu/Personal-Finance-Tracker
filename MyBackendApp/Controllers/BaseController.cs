using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBackendApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult Success(object data, string message = "Request successful")
        {
            return Ok(new { success = true, message, data });
        }

        protected IActionResult Error(string message, int statusCode = 400)
        {
            return StatusCode(statusCode, new { success = false, message });
        }
    }
  }
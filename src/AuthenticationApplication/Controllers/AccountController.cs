using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace AuthenticationApplication.Controllers
{
    [Route("")]
    [Authorize]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            var userName = HttpContext.User.Identity.Name;
            ViewData["UserName"] = userName;
            return View("Info");
        }
    }
}

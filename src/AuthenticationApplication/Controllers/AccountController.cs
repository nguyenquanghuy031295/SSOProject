using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AuthenticationApplication.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IConfigurationRoot _configuration;
        public AccountController(IConfigurationRoot configuration){
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login(){
            var userName = HttpContext.User.Identity.Name;
            var returnUrl = _configuration.GetValue<String>("LoginURL");
            if(String.IsNullOrEmpty(userName)){
                return Redirect(returnUrl);
            }
            return Ok(new string[] { "value1", "value3" });
        }
    }
}

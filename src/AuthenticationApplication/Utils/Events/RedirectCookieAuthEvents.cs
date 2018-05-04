using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System;
namespace AuthenticationApplication.Utils.Events
{
    public class RedirectCookieAuthEvents : CookieAuthenticationEvents
    {
        private readonly IConfigurationRoot _configuration;
        public RedirectCookieAuthEvents(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public override Task RedirectToLogin(CookieRedirectContext context)
        {
            string returnUrl = String.Format("{0}{1}", context.Request.Host, context.Request.Path);
            returnUrl = _configuration.GetValue<String>("LoginURL") + "?returnUrl=" + returnUrl;
            context.Response.Redirect(returnUrl);
            return Task.CompletedTask;
        }
    }
}
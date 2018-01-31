using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace RequestLocalization.Controllers
{
    public class CulturesController : Controller
    {
        public IActionResult Set(string uiCulture)
        {
            RequestCulture request = new RequestCulture(uiCulture);

            string cookieValue = CookieRequestCultureProvider.MakeCookieValue(request);

            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, cookieValue);

            return Ok();
        }
    }
}
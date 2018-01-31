using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace HTMLLocalizers.Controllers
{
    public class CultureController : Controller
    {
        [HttpPost]
        public IActionResult Set(string uiCulture, string returnUrl)
        {
            IRequestCultureFeature feature = HttpContext.Features.Get<IRequestCultureFeature>();

            RequestCulture request = new RequestCulture(feature.RequestCulture.Culture, new CultureInfo(uiCulture));

            string cookieValue = CookieRequestCultureProvider.MakeCookieValue(request);
            string cookieName = CookieRequestCultureProvider.DefaultCookieName;

            Response.Cookies.Append(cookieName, cookieValue);

            return LocalRedirect(returnUrl);
        }
    }
}
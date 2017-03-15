using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading;

namespace LocalizationSample.TestNamespace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string culture)
        {
            var ci = new CultureInfo(culture ?? "en-US");

            CultureInfo.CurrentCulture = ci;
            CultureInfo.CurrentUICulture = ci;

            return View();
        }
    }
}

using WhiteHouseGov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cloudy.CMS.ModelBinding;
using WhiteHouseGov.Models.Pages;

namespace WhiteHouseGov.Controllers
{
    public class PageController : Controller
    {
        public ActionResult StartPage([FromServices] StartPage page)
        {
            return View(page.GetType().Name, page);
        }

        public ActionResult Index([FromContentRoute] Page page)
        {
            return View(page.GetType().Name, page);
        }
    }
}

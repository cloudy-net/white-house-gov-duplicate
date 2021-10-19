using WhiteHouseGov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cloudy.CMS.ModelBinding;

namespace WhiteHouseGov.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Index([FromContentRoute] Page page)
        {
            return View(page.GetType().Name, page);
        }
    }
}

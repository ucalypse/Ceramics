using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ceramics.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Classes()
        {
            return View();
        }
    }
}
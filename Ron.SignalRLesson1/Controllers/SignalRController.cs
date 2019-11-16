using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ron.SignalRLesson1.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
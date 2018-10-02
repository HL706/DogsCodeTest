using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dogs.Models;
using Dogs.Pages;
using Ooui.AspNetCore;
using Ooui;
using Xamarin.Forms;

namespace Dogs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new DogsPage();
            var element = page.GetOouiElement();

            return new ElementResult(element, "Dogs");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

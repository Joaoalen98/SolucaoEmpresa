using System.Diagnostics;
using Empresa.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
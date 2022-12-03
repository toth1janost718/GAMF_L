using GAMF_L.Data;
using GAMF_L.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GAMF_L.Controllers
{
    public class HomeController : Controller
    {
        private readonly GAMFDbContext _Context;

        public HomeController(GAMFDbContext context)
        {
            _Context=context;
        }

        public IActionResult Index()

        {
            var students = _Context.Students.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
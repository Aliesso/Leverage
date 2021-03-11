using Leverage.Data;
using Leverage.Models;
using Leverage.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Leverage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LgContext _lgContext;
        public HomeController(ILogger<HomeController> logger,LgContext lgContext)
        {
            _lgContext = lgContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.Start = _lgContext.Start.First();
            vm.Portfolio = _lgContext.Portfolio.ToList();
            vm.Services = _lgContext.Services.ToList();
            return View(vm);
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

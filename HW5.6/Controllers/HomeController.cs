using HW5._6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW5._6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDaysOfWeekService _daysOfWeekService;
        private readonly IMonthsService _monthsService;


        public HomeController(ILogger<HomeController> logger, IDaysOfWeekService daysOfWeekService, IMonthsService monthsService)
        {
            _logger = logger;
            _daysOfWeekService = daysOfWeekService;
            _monthsService = monthsService;
        }

        public IActionResult Index()
        {
            //string[] daysOfWeek = _daysOfWeekService.GetDaysOfWeek();
            //return View(daysOfWeek);

            string[] months = _monthsService.GetMonths();
            return View(months);
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
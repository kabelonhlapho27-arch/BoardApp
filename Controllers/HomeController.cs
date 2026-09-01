// Group leader name : Kabelo Nhlapho
// Group Student nrs : 219005935; 224042163; 224037409; 220048471; 223068452; 224136508; 224069913; 219005935
// Assignment nr     : SOD226C Practical Assessment 1 · 2026
// Purpose           : The purpose of this class is to handle web requests 
//                     and navigation actions for home and general pages.

using AspNetCoreGeneratedDocument;
using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //
            //Name             : HomeController(ILogger<HomeController> logger)
            //Purpose          : Initialize logger service
            //Re-use           : None
            //Method Parameters: ILogger<HomeController> logger
            //                   logger instance used for dependency injection
            //Output Type      : None
            //
            _logger = logger;
        } // end method

        public IActionResult Index()
        {
            //
            //Name             : IActionResult Index()
            //Purpose          : Renders and displays the Home/Index view
            //Re-use           : None
            //Method Parameters: None
            //Output Type      : IActionResult
            //                   renders the corresponding Index view
            //
            return View();
        } // end method

        public IActionResult Privacy()
        {
            //
            //Name             : IActionResult Privacy()
            //Purpose          : Renders and displays the Privacy view
            //Re-use           : None
            //Method Parameters: None
            //Output Type      : IActionResult
            //                   renders the corresponding Privacy view
            //
            return View();
        } // end method

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //
            //Name             : IActionResult Error()
            //Purpose          : Generates and returns the Error view with request tracking data
            //Re-use           : None
            //Method Parameters: None
            //Output Type      : IActionResult
            //                   renders the Error view populated with an ErrorViewModel
            //
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } // end method
    } // end class HomeController
} // end BoardApp.Controllers

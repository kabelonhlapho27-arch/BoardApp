using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Boards);
        }

        public IActionResult Details(string boardCode)
        {
            var board = Repository.Boards.FirstOrDefault(b => b.BoardCode == boardCode);
            return View(board);
        }
    }
}

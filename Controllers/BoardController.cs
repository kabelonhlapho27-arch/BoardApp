using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public ViewResult Index()
        {
            return View(Repository.Boards);
        }

        public ViewResult Details(string id)
        {
            var board = Repository.GetByBoardCode(id);
            return View(board);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Board board)
        {
            if (ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was added.";
            }

            return View(board);
        }

        [HttpGet]
        public ViewResult Edit(string id)
        {
            var board = Repository.GetByBoardCode(id);
            return View(board);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Edit(Board board)
        {
            if (ModelState.IsValid)
            {
                Repository.UpdateBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was updated.";
            }

            return View(board);
        }

        [HttpGet]
        public ViewResult Delete(string id)
        {
            var board = Repository.GetByBoardCode(id);
            return View(board);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Delete(Board board)
        {
            Repository.RemoveBoard(board.BoardCode);
            ViewBag.SuccessMessage = $"Board {board.BoardCode} was deleted.";

            return View(board);
        }
    }
}

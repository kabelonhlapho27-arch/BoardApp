using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            if(ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = "Board successfully created.";
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
                ViewBag.SuccessMessage = "Board successfully updated.";
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
           
            if (board?.BoardCode != null)
            {
                Repository.RemoveBoard(board.BoardCode);
            }
            ViewBag.SuccessMessage = "Board successfully deleted.";

           
            return View(board);
        }
    }
  
}

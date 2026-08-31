using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {        
        //new shit
        public ViewResult Index()
        {
            // return the Index view with the current list of
            // Board objects in Repository
            return View(Repository.Boards);
        }
        public ViewResult Details(string id)
        {
            // Use id to find the corresponding Board
            // object in Repository (code re-use!).
            // This object must then be returned with the
            // default view.
            // No validation needs to be done at this stage,
            // it is assumed the Board object will be found in
            // Repository.
            Board? board = Repository.GetBoardCode(id);
            return View(board);
        }
        [HttpGet]
        public ViewResult Create()
        {
            // Return the default view.
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Board board)
        {
            // Check whether there have been any validation problems.
            // Repository should be updated (code re-use!) and
            // ViewBag.SuccessMessage assigned, only if MVC has successfully
            // validated the input according to the defined constraints.
            //
            // The default view must be returned with board.
            if (ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was added";
            }
            return View(board);
        }
        [HttpGet]
        public ViewResult Edit(string id)
        {
            // Use id to find the corresponding Board
            // object in Repository (code re-use!).
            // This object must then be returned with the
            // default view.
            // No validation needs to be done at this stage,
            // it is assumed the Board object will be found in
            // Repository.
            Board? board = Repository.GetBoardCode(id);
            return View(board);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Edit(Board board)
        {
            // Check whether there have been any validation problems.
            // Repository should be updated (code re-use!) and
            // ViewBag.SuccessMessage assigned, only if MVC has successfully
            // validated the input according to the defined constraints.
            //
            // The default view must be returned with board.
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
            // Use id to find the corresponding Board
            // object in Repository (code re-use!).
            // This object must then be returned with the
            // default view.
            // No validation needs to be done at this stage,
            // it is assumed the Board object will be found in
            // Repository.
            Board? board = Repository.GetBoardCode(id);
            return View(board);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Delete(Board board)
        {
            // Repository should be updated (code re-use!) and
            // ViewBag.SuccessMessage assigned.
            //
            // The default view must be returned with board.
            Repository.RemoveBoard(board.BoardCode);
            ViewBag.SuccessMessage = $"Board {board.BoardCode} was deleted.";
            return View(board);
        }

    }
}

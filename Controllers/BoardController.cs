// Group leader name : Kabelo Nhlapho
// Group Student nrs : 219005935; 224042163; 224037409; 220048471; 223068452; 224136508; 224069913; 219005935
// Assignment nr     : SOD226C Practical Assessment 1 · 2026
// Purpose           : The purpose of this class is to manage CRUD actions and
//                     handle HTTP requests for microcontroller development boards.

using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public ViewResult Index()
        {
            //
            //Name             : ViewResult Index()
            //Purpose          : Retrieves and displays a list of all microcontroller development boards
            //Re-use           : None
            //Method Parameters: None
            //Output Type      : ViewResult
            //                   returns the Index view containing the collection of boards
            //
            return View(Repository.Boards);
        } // end method

        public ViewResult Details(string id)
        {
            //
            //Name             : ViewResult Details(string id)
            //Purpose          : Retrieves and displays the details of a specific board matching the board code
            //Re-use           : Repository.GetByBoardCode()
            //Method Parameters: string id
            //                   the unique code of the board to find and view
            //Output Type      : ViewResult
            //                   returns the Details view containing the found board object
            //
            var board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Create()
        {
            //
            //Name             : ViewResult Create()
            //Purpose          : Displays the form view used to create a new board
            //Re-use           : None
            //Method Parameters: None
            //Output Type      : ViewResult
            //                   returns the empty Create view form
            //
            return View();
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Board board)
        {
            //
            //Name             : ViewResult Create(Board board)
            //Purpose          : Validates and saves a newly submitted board object to the repository
            //Re-use           : Repository.AddBoard()
            //Method Parameters: Board board
            //                   the board object containing form values to be created
            //Output Type      : ViewResult
            //                   returns the Create view with confirmation feedback or validation errors
            //
            if (ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was added.";
            } // end if

            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Edit(string id)
        {
            //
            //Name             : ViewResult Edit(string id)
            //Purpose          : Retrieves board details by code and displays the edit form
            //Re-use           : Repository.GetByBoardCode()
            //Method Parameters: string id
            //                   the unique code of the board to be edited
            //Output Type      : ViewResult
            //                   returns the Edit view populated with the existing board details
            //
            var board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Edit(Board board)
        {
            //
            //Name             : ViewResult Edit(Board board)
            //Purpose          : Validates and updates an existing board's details in the repository
            //Re-use           : Repository.UpdateBoard()
            //Method Parameters: Board board
            //                   the board object containing updated values
            //Output Type      : ViewResult
            //                   returns the Edit view with confirmation feedback or validation errors
            //
            if (ModelState.IsValid)
            {
                Repository.UpdateBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was updated.";
            } // end if

            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Delete(string id)
        {
            //
            //Name             : ViewResult Delete(string id)
            //Purpose          : Retrieves board details by code and displays the delete confirmation view
            //Re-use           : Repository.GetByBoardCode()
            //Method Parameters: string id
            //                   the unique code of the board to be deleted
            //Output Type      : ViewResult
            //                   returns the Delete view populated with the board details
            //
            var board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Delete(Board board)
        {
            //
            //Name             : ViewResult Delete(Board board)
            //Purpose          : Deletes the specified board from the repository
            //Re-use           : Repository.RemoveBoard()
            //Method Parameters: Board board
            //                   the board object containing the code of the board to delete
            //Output Type      : ViewResult
            //                   returns the Delete view with a confirmation message
            //
            Repository.RemoveBoard(board.BoardCode);
            ViewBag.SuccessMessage = $"Board {board.BoardCode} was deleted.";

            return View(board);
        } // end method
    } // end class BoardController
} // end BoardApp.Controllers

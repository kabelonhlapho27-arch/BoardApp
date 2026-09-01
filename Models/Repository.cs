// Group leader name : Kabelo Nhlapho
// Group Student nrs : 219005935; 224042163; 224037409; 220048471; 223068452; 224136508; 224069913; 219005935
// Assignment nr     : SOD226C Practical Assessment 1 · 2026
// Purpose           : The purpose of this class is to provide an in-memory data 
//                     repository and data operations for microcontroller development boards.

namespace BoardApp.Models
{
    public class Repository
    {
        private static List<Board> boards = new List<Board>();

        public static IEnumerable<Board> Boards
        {
            //
            //Name             : property IEnumerable<Board> Boards
            //Purpose          : Public property to give read access to boards instance field
            //Re-use           : none
            //Input Parameter  : none
            //Output Type      : IEnumerable<Board>
            //                   value stored in the boards field
            //
            get
            {
                return boards;
            } // end get
        } // end property

        public static void AddBoard(Board board)
        {
            //
            //Name             : void AddBoard(Board board)
            //Purpose          : Adds a new Board object to the boards collection
            //Re-use           : None
            //Method Parameters: Board board
            //                   the board object to be added to the list
            //Output Type      : None
            //
            boards.Add(board);
        } // end method

        static Repository()
        {
            //
            //Name             : Repository()
            //Purpose          : Static constructor to initialize and populate the in-memory board repository
            //Re-use           : None
            //Method Parameters: None
            //Output Type      : None
            //
            boards = new List<Board>()
            {
                new Board("1001", "Espressif", "ESP32-WROOM-32", 4096, 129.00m),
                new Board("1002", "Espressif", "ESP32-C3-MINI-1", 4096, 99.00m),
                new Board("1003", "STMicroelectronics", "STM32F103C8T6", 64, 75.00m),
                new Board("1004", "STMicroelectronics", "STM32F411CEU6", 512, 145.00m),
                new Board("1005", "Microchip", "ATmega328P", 32, 89.00m),
                new Board("1006", "Microchip", "ATmega2560", 256, 199.00m),
                new Board("1007", "WCH", "CH32V003F4P6", 16, 29.00m),
                new Board("1008", "Raspberry Pi", "Pico", 2048, 89.00m),
                new Board("1009", "Espressif", "ESP-01S", 1024, 65.00m),
                new Board("1010", "CUTfree", "CV32-BFN-01", 128, 49.00m)
            };
        } // end method

        public static Board? GetByBoardCode(string boardCode)
        {
            //
            //Name             : Board? GetByBoardCode(string boardCode)
            //Purpose          : Finds and returns a board with the specified board code
            //Re-use           : None
            //Method Parameters: string boardCode
            //                   the unique code of the board to search for
            //Output Type      : Board?
            //                   the matching Board instance if found; otherwise, null
            //
            return Repository.Boards.FirstOrDefault(b => b.BoardCode == boardCode);
        } // end method

        public static void RemoveBoard(string boardCode)
        {
            //
            //Name             : void RemoveBoard(string boardCode)
            //Purpose          : Finds and removes a board matching the specified board code from the collection
            //Re-use           : GetByBoardCode()
            //Method Parameters: string boardCode
            //                   the unique code of the board to remove
            //Output Type      : None
            //
            var board = GetByBoardCode(boardCode);
            if (board != null)
            {
                boards.Remove(board);
            } // end if
        } // end method

        public static void UpdateBoard(Board updatedBoard)
        {
            //
            //Name             : void UpdateBoard(Board updatedBoard)
            //Purpose          : Finds an existing board and updates its properties with new values
            //Re-use           : GetByBoardCode()
            //Method Parameters: Board updatedBoard
            //                   the board object containing updated data
            //Output Type      : None
            //
            var existingBoard = GetByBoardCode(updatedBoard.BoardCode);
            if (existingBoard != null)
            {
                existingBoard.Make = updatedBoard.Make;
                existingBoard.Model = updatedBoard.Model;
                existingBoard.FlashKb = updatedBoard.FlashKb;
                existingBoard.Price = updatedBoard.Price;
            } // end if
        } // end method
    } // end class Repository
} // end BoardApp.Models

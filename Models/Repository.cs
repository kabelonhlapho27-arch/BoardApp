namespace BoardApp.Models
{
    public class Repository
    {
        private static List<Board> boards = new List<Board>();

        public static IEnumerable<Board> Boards
        {
            get { return boards; }
        }

        public static void AddBoard(Board board)
        {
            boards.Add(board);
        }

    }
}


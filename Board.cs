namespace ShipsGame
{
    internal class Board
    {
        public char[,] board =
        {
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
        };
        public void ShowBoard()
        {
            Console.WriteLine("     +---+---+---+---+---+---+---+---+---+---+");
            Console.WriteLine("     | A | B | C | D | E | F | G | H | I | J |");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("+----+---+---+---+---+---+---+---+---+---+---+");
                if (i == 9)
                {
                    Console.Write("| " + (i + 1) + " | ");
                }
                else
                {
                    Console.Write("| " + (i + 1) + "  | ");
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(board[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" | ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("+----+---+---+---+---+---+---+---+---+---+---+");
        }
        public void TempToSinked()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (board[i, j] == 't')
                    {
                        board[i, j] = '*';
                    }
                }
            }
        }
    }
}

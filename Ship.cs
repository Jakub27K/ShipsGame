namespace ShipsGame
{
    internal class Ship
    {
        public Ship(int[] fields, Player p)
        {
            if (fields.Length == 2)
            {
                p.boardForShips.board[fields[0], fields[1]] = 's';
            }
            else if (fields.Length == 4)
            {
                p.boardForShips.board[fields[0], fields[1]] = 's';
                p.boardForShips.board[fields[2], fields[3]] = 's';

            }
            else if (fields.Length == 6)
            {
                p.boardForShips.board[fields[0], fields[1]] = 's';
                p.boardForShips.board[fields[2], fields[3]] = 's';
                p.boardForShips.board[fields[4], fields[5]] = 's';
            }
            else if (fields.Length == 8)
            {
                p.boardForShips.board[fields[0], fields[1]] = 's';
                p.boardForShips.board[fields[2], fields[3]] = 's';
                p.boardForShips.board[fields[4], fields[5]] = 's';
                p.boardForShips.board[fields[6], fields[7]] = 's';
            }
            p.ships++;
            Console.Clear();
            p.boardForShips.ShowBoard();
        }
    }
}

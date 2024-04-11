namespace ShipsGame
{
    internal class Player
    {
        public int id, ships = 0;
        public Board boardForShooting = new Board(), boardForShips = new Board();
        public Player(int id)
        {
            this.id = id;
        }
    }
}
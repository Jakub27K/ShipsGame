using ShipsGame;

namespace Program
{
    class Program
    {

        public static void Main(string[] args)
        {
            Game game = new Game();
            game.shipPlacing();
            game.ChangePlayers();
            game.shipPlacing();
            while (game.DoesPlayerWonTheGame() == false)
            {
                game.ChangePlayers();
                game.Shooting();
            }
            Console.Clear();
            Console.WriteLine($"Wygrywa gracz: " + game.secondaryPlayer.id);
        }
    }
}
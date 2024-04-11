using System.Data.Common;
using System.Numerics;

namespace ShipsGame
{
    internal class Game
    {

        public Player nowPlayer = new Player(1), secondaryPlayer = new Player(2);
        bool IsFieldOnBoardOccupied(char t, Player p, int[] field)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    try
                    {
                        if (p.boardForShips.board[field[0] + i, field[1] + j] == t)
                        {
                            return true;
                        }
                    }
                    catch (Exception) { }
                }
            }
            return false;
        }
        public int[] GetPlayerField(bool takeDirection)
        {
            int letterToInt;
            int horizontal = 0;
            char[] arrOfAllowedLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            Console.WriteLine("Podaj literę A-J:");
            char inputLetter = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (Array.IndexOf(arrOfAllowedLetters, inputLetter) != -1)
            {
                letterToInt = Array.IndexOf(arrOfAllowedLetters, inputLetter);
            }
            else
            {
                Console.WriteLine("Podano niepoprawną literę.\n\n");
                return GetPlayerField(takeDirection);
            }

            Console.WriteLine("\nPodaj liczbę od 1 do 10:");
            string inputNumberStr = Console.ReadLine();



            int inputNumber;

            if (int.TryParse(inputNumberStr, out inputNumber) && inputNumber >= 1 && inputNumber <= 10)
            {
                inputNumber--;
                if (takeDirection)
                {
                    Console.WriteLine("Jeśli postawić poziomo wpisz 't' jeśli pionowo kliknij enter");
                    if (Console.ReadLine().ToLower() == "t")
                    {
                        horizontal = 1;
                    }
                    if (IsFieldOnBoardOccupied('s', nowPlayer, [inputNumber, letterToInt]))
                    {
                        Console.WriteLine("Pole zajęte.\n\n");
                        return GetPlayerField(takeDirection);
                    }
                    return [inputNumber, letterToInt, horizontal];
                }
                else
                {
                    return [inputNumber, letterToInt];
                }

            }
            else
            {
                Console.WriteLine("Podano niepoprawną liczbę.\n\n");
                return GetPlayerField(takeDirection);
            }
        }
        public void shipPlacing()
        {
            nowPlayer.boardForShips.ShowBoard();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Teraz stawiasz statek 1-masztowy");
                Ship ship = new Ship(GetPlayerField(false), nowPlayer);

            }
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Teraz stawiasz statek 2-masztowy");
                Console.WriteLine("Wybierz gdzie zaczyna się statek");
                int[] field = GetPlayerField(true);
                if (field[2] == 1)
                {
                    if (field[1] + 1 < 10)
                    {
                        if (IsFieldOnBoardOccupied('s', nowPlayer, [field[0], field[1] + 1]))
                        {
                            Console.WriteLine("Pole zajęte.\n\n");
                        }
                        else
                        {
                            Ship ship = new Ship([field[0], field[1], field[0], field[1] + 1], nowPlayer);
                            count++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Pole pole poza zasięgiem.\n\n");
                    }

                }
                else
                {
                    if (field[0] + 1 < 10)
                    {
                        if (IsFieldOnBoardOccupied('s', nowPlayer, [field[0] + 1, field[1]]))
                        {
                            Console.WriteLine("Pole zajęte.\n\n");
                        }
                        else
                        {
                            Ship ship = new Ship([field[0], field[1], field[0] + 1, field[1]], nowPlayer);
                            count++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Pole pole poza zasięgiem.\n\n");
                    }
                }
            }
            count = 0;
            while (count < 2)
            {
                Console.WriteLine("Teraz stawiasz statek 3-masztowy");
                Console.WriteLine("Wybierz gdzie zaczyna się statek");
                int[] field = GetPlayerField(true);
                if (field[2] == 1)
                {
                    if (field[1] + 2 < 10)
                    {
                        if (IsFieldOnBoardOccupied('s', nowPlayer, [field[0], field[1] + 2]))
                        {
                            Console.WriteLine("Pole zajęte.\n\n");
                        }
                        else
                        {
                            Ship ship = new Ship([field[0], field[1], field[0], field[1] + 1, field[0], field[1] + 2], nowPlayer);
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pole pole poza zasięgiem.\n\n");
                    }

                }
                else
                {
                    if (field[0] + 2 < 10)
                    {
                        if (IsFieldOnBoardOccupied('s', nowPlayer, [field[0] + 2, field[1]]))
                        {
                            Console.WriteLine("Pole zajęte.\n\n");
                        }
                        else
                        {
                            Ship ship = new Ship([field[0], field[1], field[0] + 1, field[1], field[0] + 2, field[1]], nowPlayer);
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pole pole poza zasięgiem.\n\n");
                    }
                }
            }
            count = 0;
            while (count < 1)
            {
                Console.WriteLine("Teraz stawiasz statek 4-masztowy");
                Console.WriteLine("Wybierz gdzie zaczyna się statek");
                int[] field = GetPlayerField(true);
                if (field[2] == 1)
                {
                    if (field[1] + 3 < 10)
                    {
                        if (IsFieldOnBoardOccupied('s', nowPlayer, [field[0], field[1] + 3]))
                        {
                            Console.WriteLine("Pole zajęte.\n\n");
                        }
                        else
                        {
                            Ship ship = new Ship([field[0], field[1], field[0], field[1] + 1, field[0], field[1] + 2, field[0], field[1] + 3], nowPlayer);
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pole pole poza zasięgiem.\n\n");
                    }

                }
                else
                {
                    if (field[0] + 3 < 10)
                    {
                        if (IsFieldOnBoardOccupied('s', nowPlayer, [field[0] + 3, field[1]]))
                        {
                            Console.WriteLine("Pole zajęte.\n\n");
                        }
                        else
                        {
                            Ship ship = new Ship([field[0], field[1], field[0] + 1, field[1], field[0] + 2, field[1], field[0] + 3, field[1]], nowPlayer);
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pole pole poza zasięgiem.\n\n");
                    }
                }
            }
            Console.WriteLine("Kliknij enter aby kontynuować");
            Console.ReadKey();
        }
        public void ChangePlayers()
        {
            Console.Clear();
            Console.WriteLine("Zmień gracza przed komputerem a następnie kliknij jakikolwiek przycisk");
            Console.ReadKey();
            Player temp = nowPlayer;
            nowPlayer = secondaryPlayer;
            secondaryPlayer = temp;
        }
        int HowManyTargets(int[] field, Player p, char t)
        {
            int toReturn = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    try
                    {
                        if (p.boardForShips.board[field[0] + i, field[1] + j] == t)
                        {
                            toReturn++;
                        }
                    }
                    catch (Exception e)
                    {
                    }
                }
            }
            return toReturn;
        }
        bool IsShipHitted(int[] field, Player p, Player p2)
        {
            p2.boardForShooting.board[field[0], field[1]] = 't';
            p.boardForShips.board[field[0], field[1]] = 't';
            if (HowManyTargets([field[0], field[1]], p, 's') >= 1)
            {
                return false;
                p2.boardForShooting.board[field[0], field[1]] = 'x';
                p.boardForShips.board[field[0], field[1]] = 'x';
            }
            int targets = HowManyTargets([field[0], field[1]], p, 'x');
            if (targets == 0)
            {
                return true;
            }
            else if (targets == 1)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        try
                        {
                            if (p.boardForShips.board[field[0] + i, field[1] + j] == 'x')
                            {
                                p2.boardForShooting.board[field[0], field[1]] = 't';
                                p.boardForShips.board[field[0] + i, field[1] + j] = 't';
                                return IsShipHitted([field[0] + i, field[1] + j], p, p2);
                            }
                        }
                        catch (Exception) { }
                    }
                }
            }
            else
            {
                int[] arr = [0, 0, 0, 0];
                int temp = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        try
                        {
                            if (p.boardForShips.board[field[0] + i, field[1] + j] == 'x')
                            {
                                arr[temp] = field[0] + i;
                                arr[temp + 1] = field[1] + j;
                                temp = 2;
                            }
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                if (IsShipHitted([arr[0], arr[1]], p, p2) && IsShipHitted([arr[2], arr[3]], p, p2))
                {
                    return true;
                }
            }
            return false;
        }
        void TempsToSinked()
        {
            nowPlayer.boardForShooting.TempToSinked();
            nowPlayer.boardForShips.TempToSinked();
            secondaryPlayer.boardForShooting.TempToSinked();
            secondaryPlayer.boardForShips.TempToSinked();
        }
        public bool DoesPlayerWonTheGame()
        {
            return (nowPlayer.ships == 0 || secondaryPlayer.ships == 0);
        }
        public void Shooting()
        {
            nowPlayer.boardForShooting.ShowBoard();
            int[] field = GetPlayerField(false);
            if (secondaryPlayer.boardForShips.board[field[0], field[1]] == 's')
            {
                if (IsShipHitted(field, secondaryPlayer, nowPlayer))
                {
                    Console.WriteLine("Zatopiony");
                    nowPlayer.boardForShooting.board[field[0], field[1]] = '*';
                    secondaryPlayer.boardForShips.board[field[0], field[1]] = '*';
                    secondaryPlayer.ships--;
                }
                else
                {
                    Console.WriteLine("Trafiony");
                    nowPlayer.boardForShooting.board[field[0], field[1]] = 'x';
                    secondaryPlayer.boardForShips.board[field[0], field[1]] = 'x';
                }
                Console.ReadKey();
                TempsToSinked();
                if (!DoesPlayerWonTheGame())
                {
                    Shooting();
                }
            }
            else
            {
                Console.WriteLine("Puste pole");
                Console.ReadKey();
                TempsToSinked();
            }

        }
    }
}
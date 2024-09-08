using System;
using System.Collections.Generic;
using System.Linq;

namespace DozGame
{
    public class Program
    {
        static void Main(string[] args)
        {

            var gameDriver = new GameDriver();
            var random = new Random();


            PrintBoard(gameDriver.Game.Board);

            while (!gameDriver.Game.IsGameOver())
            {
                var currentPlayer = gameDriver.Currentplayer;
                Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Symbol})");


                int row, column;
                do
                {
                    row = random.Next(0, gameDriver.Rows);
                    column = random.Next(0, gameDriver.Columns);
                } while (gameDriver.IsSquareTaken(row, column));


                gameDriver.SetSquare(new DozGameModel(row, column, currentPlayer.Symbol));


                PrintBoard(gameDriver.Game.Board);


                if (gameDriver.Game.IsGameOver())
                {
                    break;
                }


                gameDriver.SwitchPlayer();
            }


            if (gameDriver.Game.IsDraw())
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                var winner = gameDriver.GetWinner();
                Console.WriteLine($"{winner.Name} ({winner.Symbol}) wins!");
            }
        }

        static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    char symbol = board.Squares[i, j].IsTaken() ? board.Squares[i, j].Symbol : '-';
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game(); // initilize new game

            var message = "";
            game.gameBoard.PrintBoard(game.chessPieces, message);
            
            while (game.whitePlayer.gameRoundUpdater.KingAlive() && game.blackPlayer.gameRoundUpdater.KingAlive())
            {
                game.whitePlayer.gameRoundUpdater.AddAvailableMovesToAll();

                var info = game.whitePlayer.MovePiece();
                message = info.Message();
                game.gameBoard.PrintBoard(game.chessPieces, message);
                
                game.NewClear();

                Console.ReadKey();
                game.blackPlayer.gameRoundUpdater.AddAvailableMovesToAll();

                info = game.blackPlayer.MovePiece();
                message = info.Message();
                game.gameBoard.PrintBoard(game.chessPieces, message);
                game.NewClear();
                
                Console.ReadKey();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Thread.Sleep(5000);
            
            
        }
    }
}

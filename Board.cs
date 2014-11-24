using ConsoleChessGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessVersion3
{
    public class Board 
    {
        public string[,] ChessBoard { get; set; }
       
        public Board()
        {
            ChessBoard = new string[8, 8];
        }

        public void PrintBoard(List<ChessPiece> chessPieces, string message)
        {
            Console.Clear(); // clearing the board before every turn.
            
            PrintTiles(); // prints the sqaures of the board.

            PrintPiecesOnToBoard(chessPieces); 

            PrintPositionList();
            
            Console.WriteLine();
            
            Console.WriteLine(message);
        }

        private void PrintPositionList()
        {
            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    Console.Write(ChessBoard[x, y]);
                }
                Console.WriteLine();
            }
        }

        private void PrintPiecesOnToBoard(List<ChessPiece> chessPieces)
        {
            foreach (var piece in chessPieces)
            {
                if (piece.color == ConsoleColor.White)
                {
                    ChessBoard[piece.position.X, piece.position.Y] = piece._whiteSymbol;
                }

                else
                {
                    ChessBoard[piece.position.X, piece.position.Y] = piece._blackSymbol;
                }
            }
            
        }

        private void PrintTiles()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    ChessBoard[x, y] = "[  ]";
                }
            }
        }

    }
}

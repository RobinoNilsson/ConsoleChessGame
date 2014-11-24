using ChessVersion3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public class Game
    {
       public Board gameBoard;
       public Player blackPlayer;
       public Player whitePlayer;
       public List<ChessPiece> chessPieces;
       public GameRoundUpdater gameRoundUpdater;
        
        public Game()
        {
            gameBoard = new Board();
            chessPieces = new List<ChessPiece>();
            CreateAllGamePieces();
            blackPlayer = new Player(ConsoleColor.Black, chessPieces);
            whitePlayer = new Player(ConsoleColor.White, chessPieces);
            

        }
        
        private void CreateAllGamePieces()
        {
           
            //White players is created here
            chessPieces.Add(new Pawn(new Position(0, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(1, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(2, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(3, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(4, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(5, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(6, 6), ConsoleColor.Black));
            chessPieces.Add(new Pawn(new Position(7, 6), ConsoleColor.Black));
            chessPieces.Add(new Knight(new Position(1, 7), ConsoleColor.Black));
            chessPieces.Add(new Knight(new Position(6, 7), ConsoleColor.Black));
            chessPieces.Add(new Bishop(new Position(2, 7), ConsoleColor.Black));
            chessPieces.Add(new Bishop(new Position(5, 7), ConsoleColor.Black));
            chessPieces.Add(new Rook(new Position(0, 7), ConsoleColor.Black));
            chessPieces.Add(new Rook(new Position(7, 7), ConsoleColor.Black));
            chessPieces.Add(new Queen(new Position(3, 7), ConsoleColor.Black));
            chessPieces.Add(new King(new Position(4, 7), ConsoleColor.Black));

            //Black players is created here
            chessPieces.Add(new Pawn(new Position(0, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(1, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(2, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(3, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(4, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(5, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(6, 1), ConsoleColor.White));
            chessPieces.Add(new Pawn(new Position(7, 1), ConsoleColor.White));
            chessPieces.Add(new Knight(new Position(1, 0), ConsoleColor.White));
            chessPieces.Add(new Knight(new Position(6, 0), ConsoleColor.White));
            chessPieces.Add(new Bishop(new Position(2, 0), ConsoleColor.White));
            chessPieces.Add(new Bishop(new Position(5, 0), ConsoleColor.White));
            chessPieces.Add(new Rook(new Position(0, 0), ConsoleColor.White));
            chessPieces.Add(new Rook(new Position(7, 0), ConsoleColor.White));
            chessPieces.Add(new Queen(new Position(3, 0), ConsoleColor.White));
            chessPieces.Add(new King(new Position(4, 0), ConsoleColor.White));
        }

        public void NewClear()
        {
            foreach (var piece in chessPieces)
            {
                piece.availableMoves.Clear();
                piece._canKill = false;
                piece._canMove = false;

            }
        }
    }
}

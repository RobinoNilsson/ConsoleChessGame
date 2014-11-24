using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public class GameRoundUpdater
    {
        List<ChessPiece> chessPieces;
        Player player;
       
        public GameRoundUpdater(List<ChessPiece> chessPieces, Player player)
        {
            this.chessPieces = chessPieces;
            this.player = player;
        } 

        public bool InsideOfBoard(Position move) // Check if out of board before move.
        {
            return move.X >= 0 && move.X <= 7 && move.Y >= 0 && move.Y <= 7;
        }

        public bool PieceInTheWay(Position move)  // Check if anyone in the way.
        {
            foreach (var piece in chessPieces)
            {
                if (piece.position.X == move.X && piece.position.Y == move.Y)
                {
                    return true;
                }

            }

            return false;
        }

        public bool CheckIfEnemy(Position move, ConsoleColor color) //Checks if it's an enemy in the way.
        {
            foreach (var piece in chessPieces)
            {
                if (move.X == piece.position.X && move.Y == piece.position.Y && piece.color != color)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsDiagonalMove(Position move, ChessPiece piece)
        {
            if (move.X != piece.position.X && move.Y != piece.position.Y)
            {
                return true;
            }

            return false;
        } //Check pawns available kill

        public bool IsVerticalMove(Position move, ChessPiece piece)
        {
            if (move.X == piece.position.X && move.Y != piece.position.Y)
            {
                return true;
            }

            return false;
        } //Check pawns available move

        public void AddAvailableMovesToAll() // Method for using movements for pieces other than pawn.
        {
            foreach (var piece in chessPieces)
            {
                if (piece.type == ChessPieceType.Pawn)
                {
                    AddAvailableMovesToPawns(piece);
                }

                else
                    AddAvailableMoves(piece);

            }


        }
       
        public void AddAvailableMovesToPawns(ChessPiece piece) // Add the moves for Pawn
        {

            foreach (var moveList in piece.possibleMoves)
            {
                foreach (var move in moveList)
                {
                    Position pos = new Position(piece.position.X + move.X, piece.position.Y + move.Y);

                    if (InsideOfBoard(pos) &&
                         PieceInTheWay(pos) &&
                         IsVerticalMove(pos, piece))
                    {
                        break;
                    }

                    if (InsideOfBoard(pos) &&
                        PieceInTheWay(pos) &&
                        CheckIfEnemy(pos, player.color) &&
                        IsDiagonalMove(pos, piece))
                    {
                        piece._canKill = true;
                        piece._canMove = true;
                        piece.availableMoves.Add(pos);
                        break;
                    }

                    if (InsideOfBoard(pos) &&
                        PieceInTheWay(pos) == false &&
                        IsVerticalMove(pos, piece))
                    {
                        piece._canMove = true;
                        piece._canKill = false;

                        piece.availableMoves.Add(pos);

                    }

                }
            }

        }
       
        public void AddAvailableMoves(ChessPiece piece)
        {

            foreach (var moveList in piece.possibleMoves)
            {
                foreach (var move in moveList)
                {
                    Position pos = new Position(piece.position.X + move.X, piece.position.Y + move.Y);

                    if (InsideOfBoard(pos) &&
                         PieceInTheWay(pos) &&
                         CheckIfEnemy(pos, player.color) == false)
                    {
                        break;
                    }

                    if (InsideOfBoard(pos) &&
                        PieceInTheWay(pos) &&
                        CheckIfEnemy(pos, player.color))
                    {
                        piece._canKill = true;
                        piece._canMove = true;
                        piece.availableMoves.Add(pos);
                        break;
                    }

                    if (InsideOfBoard(pos) &&
                        PieceInTheWay(pos) == false)
                    {
                        piece._canMove = true;
                        piece._canKill = false;

                        piece.availableMoves.Add(pos);

                    }

                }
            }

        }

        public bool KingAlive()
        {
            
            List<ChessPiece> Kings = new List<ChessPiece>();
            foreach (var piece in chessPieces)
            {
                if (piece.type == ChessPieceType.King)
                {
                    Kings.Add(piece);
                }
            }

            if(Kings.Count == 2)
            {
                return true;
            }

            return false;
        }
    }
}

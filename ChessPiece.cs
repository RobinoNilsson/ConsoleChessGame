using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public abstract class ChessPiece
    {

        public bool _canKill; // if piece can kill = true
        public bool _canMove; // if piece can move = true
        public bool _threatened; // Not in use yet, but should hold if a piece can be killed.
        public Position position;  // holds position x, y for piece
        public List<List<Position>> possibleMoves; // Holds everypossible move for seperated pieces in lists.
        public List<Position> availableMoves; // everywhere after controll of possiblemoves.
        public string _whiteSymbol; // a unique symbol for every white piece.
        public string _blackSymbol; // a unique symbol for every black piece.
        public ConsoleColor color; // player and piece color
        public ChessPieceType type; // Enum check value of the piece type and other.



        public ChessPiece(ConsoleColor color, Position position) // Every Piece Contains
        {
            this.color = color;
            this.position = position;
            availableMoves = new List<Position>();
        }
    }
}

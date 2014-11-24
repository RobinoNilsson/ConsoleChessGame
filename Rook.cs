using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    class Rook : ChessPiece
    {
        public Rook(Position position, ConsoleColor color)
            : base(color, position)
        {
            _blackSymbol = "[bR]";
            _whiteSymbol = "[wR]";
            type = ChessPieceType.Rook;
            possibleMoves = new List<List<Position>>();


            possibleMoves.Add(new List<Position>
            {
                new Position(0,1),
                new Position(0,2),
                new Position(0,3),
                new Position(0,4),
                new Position(0,5),
                new Position(0,6),
                new Position(0,7)
              
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(0,-1),
                new Position(0,-2),
                new Position(0,-3),
                new Position(0,-4),
                new Position(0,-5),
                new Position(0,-6),
                new Position(0,-7)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(1,0),
                new Position(2,0),
                new Position(3,0),
                new Position(4,0),
                new Position(5,0),
                new Position(6,0),
                new Position(7,0)
            });
            possibleMoves.Add(new List<Position>
            {
                new Position(-1,0),
                new Position(-2,0),
                new Position(-3,0),
                new Position(-4,0),
                new Position(-5,0),
                new Position(-6,0),
                new Position(-7,0)

            });


        }
    }
}

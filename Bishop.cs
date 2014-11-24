using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    class Bishop : ChessPiece
    {

        public Bishop(Position position, ConsoleColor color)
            : base(color, position)
        {
            _blackSymbol = "[bB]";
            _whiteSymbol = "[wB]";
            type = ChessPieceType.Bishop;
            possibleMoves = new List<List<Position>>();

            // sets the list with possible moves before controlling where the available moves are set in an other list.
            // this case diagonal moves for an bishop
            
            possibleMoves.Add(new List<Position>
            {
                new Position(1,1),
                new Position(2,2),
                new Position(3,3),
                new Position(4,4),
                new Position(5,5),
                new Position(6,6),
                new Position(7,7)
              
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(-1,-1),
                new Position(-2,-2),
                new Position(-3,-3),
                new Position(-4,-4),
                new Position(-5,-5),
                new Position(-6,-6),
                new Position(-7,-7)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(1,-1),
                new Position(2,-2),
                new Position(3,-3),
                new Position(4,-4),
                new Position(5,-5),
                new Position(6,-6),
                new Position(7,-7)
            });
            possibleMoves.Add(new List<Position>
            {
                new Position(-1,1),
                new Position(-2,2),
                new Position(-3,3),
                new Position(-4,4),
                new Position(-5,5),
                new Position(-6,6),
                new Position(-7,7)

            });

        }
    }
}

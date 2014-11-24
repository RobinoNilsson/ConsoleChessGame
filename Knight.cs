using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    class Knight : ChessPiece
    {
        public Knight(Position position, ConsoleColor color)
            : base(color, position)
        {
            _blackSymbol = "[bk]";
            _whiteSymbol = "[wk]";
            type = ChessPieceType.Knight;
            possibleMoves = new List<List<Position>>();


            possibleMoves.Add(new List<Position>
            {
                new Position(-1,2),
                new Position(-2,1)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(2,1),
                new Position(1,2)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(2,-1),
                new Position(1,-2)
            });
            possibleMoves.Add(new List<Position>
            {
                new Position(-1,-2),
                new Position(-2,-1)
            });


        }
    }
}

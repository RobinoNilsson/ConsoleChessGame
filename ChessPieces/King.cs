using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    class King : ChessPiece
    {
        public King(Position position, ConsoleColor color)
            : base(color, position)
        {
            
            _blackSymbol = "[bK]";
            _whiteSymbol = "[wK]";
            type = ChessPieceType.King;
            possibleMoves = new List<List<Position>>();

            possibleMoves.Add(new List<Position>
            {
                new Position(1,1)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(-1,-1)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(1,-1)
            });
            possibleMoves.Add(new List<Position>
            {
                new Position(-1,1)
            });
            possibleMoves.Add(new List<Position>
            {
                new Position(0,1) 
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(0,-1)
            });

            possibleMoves.Add(new List<Position>
            {
                new Position(1,0)
            });
            possibleMoves.Add(new List<Position>
            {
                new Position(-1,0)
            });


        }
    }
}

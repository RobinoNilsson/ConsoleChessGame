using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public class Pawn : ChessPiece
    {
        public bool _firstmove;


        public Pawn(Position position, ConsoleColor color)
            : base(color, position)
        {
            _firstmove = true;
            _blackSymbol = "[bP]";
            _whiteSymbol = "[wP]";
            type = ChessPieceType.Pawn;

            possibleMoves = new List<List<Position>>();

            if (color == ConsoleColor.White)
            {
                possibleMoves.Add(new List<Position>
            {
                new Position(0, 1),
                new Position(0,2),
              
            });

                possibleMoves.Add(new List<Position>
            {
                new Position(-1,1)
            });

                possibleMoves.Add(new List<Position>
            {
               new Position(1,1),
            });
            }

            //.------------------------------------------------------------------- 

            if (color == ConsoleColor.Black)
            {
                possibleMoves.Add(new List<Position>
            {
                new Position(0, -1),
                new Position(0,-2),
              
            });

                possibleMoves.Add(new List<Position>
            {
                new Position(-1,-1)
            });

                possibleMoves.Add(new List<Position>
            {
               new Position(1,-1),
            });

            }


        }

        public void SetNewPossibleMovesAfterFirstMove()
        {
            possibleMoves = new List<List<Position>>();

            if (color == ConsoleColor.White)
            {
                possibleMoves.Add(new List<Position>
            {
                new Position(0, 1)
               
              
            });

                possibleMoves.Add(new List<Position>
            {
                new Position(-1,1)
            });

                possibleMoves.Add(new List<Position>
            {
               new Position(1,1)
            });
            }

            //.------------------------------------------------------------------- 

            if (color == ConsoleColor.Black)
            {
                possibleMoves.Add(new List<Position>
            {
                new Position(0, -1)
              
              
            });

                possibleMoves.Add(new List<Position>
            {
                new Position(-1,-1)
            });

                possibleMoves.Add(new List<Position>
            {
               new Position(1,-1)
            });
            }
        }
    }
}

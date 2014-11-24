using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public class MoveInfo
    {
        ChessPiece ally;
        public ConsoleColor enemyColor;
        public ChessPieceType enemyType;
        
        int OldX;
        int OldY;
        
        public MoveInfo(ChessPiece ally, ConsoleColor enemyColor, ChessPieceType enemyType, int OldX, int OldY)
        {
            this.OldX = OldX;
            this.OldY = OldY;
            this.ally = ally;
            this.enemyColor = enemyColor;
            this.enemyType = enemyType;
        }

        public MoveInfo(ChessPiece ally, int OldX, int OldY)
        {
            this.OldX = OldX;
            this.OldY = OldY;
            this.ally = ally;
        }

        public string Message() 
        {
            
            if (enemyType != 0)
            {
                return string.Format("{0} moved from {1}, {2}, to {3},{4} and PWNED {5} {6}", ally.type, OldX, OldY, ally.position.X, ally.position.Y, enemyColor, enemyType);

            }
            else
                return string.Format("{0} moved from {1}, {2}, to {3},{4}", ally.type, OldX, OldY, ally.position.X, ally.position.Y);
        }
    }
}

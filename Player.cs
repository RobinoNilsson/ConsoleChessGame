using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public class Player
    {
        public ConsoleColor color;
        public List<ChessPiece> chessPieces;
        public GameRoundUpdater gameRoundUpdater;

        public Player(ConsoleColor color, List<ChessPiece> chessPieces)
        {
            this.color = color;
            this.chessPieces = chessPieces;
            gameRoundUpdater = new GameRoundUpdater(chessPieces, this);
        }

        public MoveInfo MovePiece()    
        
        {
            Random rnd = new Random();

            int index = rnd.Next(GetPiecesThatCanMove().Count);

            ChessPiece pieceToMove = GetPiecesThatCanMove()[index];

            index = rnd.Next(pieceToMove.availableMoves.Count);

            Position pos = pieceToMove.availableMoves[index];

            if (pieceToMove.type == ChessPieceType.Pawn)
            {
                Pawn pawn = (Pawn)pieceToMove;
                pawn.SetNewPossibleMovesAfterFirstMove();
                pawn._firstmove = false;
            }

            ChessPiece ToRemove = null;
            
            MoveInfo info = new MoveInfo(pieceToMove, pieceToMove.position.X, pieceToMove.position.Y);
            
            foreach (var piece in GetEnemyPieces())
            {
                if(
                piece.position.X == pos.X &&
                piece.position.Y == pos.Y)
                {
                    ToRemove = piece;
                }
            }

            if (ToRemove != null)
            {
                info.enemyColor = ToRemove.color;
                info.enemyType = ToRemove.type;
                chessPieces.Remove(ToRemove);
            }
           
            pieceToMove.position.X = pos.X;
            pieceToMove.position.Y = pos.Y;

            return info;
            
        }
       
        public List<ChessPiece> GetPiecesThatCanMove()
        {
            List<ChessPiece> result = new List<ChessPiece>();
            
            foreach (var piece in chessPieces)
            {
                if (piece._canMove == true && piece.color == color)
                {
                    result.Add(piece);
                }
            }

            return result;
        }

        public List<ChessPiece> GetPiecesThatCanKill()
        {
            return chessPieces.Where(x => x._canKill == true && x.color == color).ToList();
        }

        public void GetAllyPieces()
        {

        }
       
        public  List<ChessPiece> GetEnemyPieces()
        {
            var enemyPieces = new List<ChessPiece>();
            
            foreach (var piece in chessPieces)
            {
                if(piece.color != color)
                {
                    enemyPieces.Add(piece);
                }
            }
            return enemyPieces;
        }

        public void GetEnemyThatCanKill()
        {

        }

        public void GetEnemyThatCanMove()
        {

        }

       
    }
}

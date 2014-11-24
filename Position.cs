using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return "X " +  X  + " Y " + Y;
        }
    }
}

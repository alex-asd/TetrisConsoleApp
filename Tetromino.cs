using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class Tetromino
    {
        public bool[,] Body { get; private set; }

        public Tetromino(bool[,] body)
        {
            this.Body = body;
        }

        public int Width => this.Body.GetLength(0);

        public int Height => this.Body.GetLength(1);
    }
}

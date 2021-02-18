using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class Figures
    {
        public readonly List<Tetromino> TetrisFigures = new List<Tetromino>()
            {
                // I
                new Tetromino(new bool[,]
                {
                    { true, true, true, true }
                }),
                // O
                new Tetromino(new bool[,]
                {
                    { true, true },
                    { true, true }
                }),
                // T
                new Tetromino(new bool[,]
                {
                    { false, true, false },
                    { true, true, true },
                }),
                // S
                new Tetromino(new bool[,]
                {
                    { false, true, true, },
                    { true, true, false, },
                }),
                // Z
                new Tetromino(new bool[,]
                {
                    { true, true, false },
                    { false, true, true },
                }),
                // J
                new Tetromino(new bool[,]
                {
                    { true, false, false },
                    { true, true, true }
                }),
                // L
                new Tetromino(new bool[,]
                {
                    { false, false, true },
                    { true, true, true }
                }),
            };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class Window
    {
        private int gameRows;
        private int gameCols;
        private int informationCols;
        private int consoleRows ;
        private int consoleCols;
        private char gameCharacter;

        public int Frame { get; set; }
        public int FramesToMoveFigure { get; private set; }

        public Window(int gameRows, int gameCols, char gameCharacter, int informationCols)
        {
            this.gameRows = gameRows;
            this.gameCols = gameCols;
            this.gameCharacter = gameCharacter;
            this.informationCols = informationCols;

            this.consoleRows = this.gameRows + 2;
            this.consoleCols = this.gameCols + this.informationCols + 3;

            this.Frame = 0;
            this.FramesToMoveFigure = 15;

            Console.Title = "Tetris";
            Console.WindowHeight = this.consoleRows + 1;
            Console.BufferHeight = this.consoleRows + 1;
            Console.WindowWidth = this.consoleCols;
            Console.BufferWidth = this.consoleCols; 
            Console.CursorVisible = false;
            DisplayBorder();
            DisplayGameInfo(gameCols + 3);
        }

        public void DisplayBorder()
        {
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            line += new string('═', this.gameCols);

            line += "╦";
            line += new string('═', this.informationCols);
            line += "╗";
            Console.Write(line);

            for (int i = 0; i < this.gameRows; i++)
            {
                string middleLine = "║";
                middleLine += new string(' ', this.gameCols);
                middleLine += "║";
                middleLine += new string(' ', this.informationCols);
                middleLine += "║";
                Console.Write(middleLine);
            }

            string endLine = "╚";
            endLine += new string('═', this.gameCols);
            endLine += "╩";
            endLine += new string('═', this.informationCols);
            endLine += "╝";
            Console.Write(endLine);
        }

        private void Write(string text, int row, int col)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(text);
        }

        public void DisplayGameInfo(int position)
        {
            // Hardcode values for testing the display
            Write("Level:", 1, position);
            Write("0", 2, position);
            Write("Score:", 1, position);
            Write("0", 2, position);
            Write("Best:", 7, position);
            Write("1000", 8, position);
            Write("Keys:", 16, position);
            Write($"  ^ ", 18, position);
            Write($"<   > ", 19, position);
            Write($"  v  ", 20, position);
        }

        public void DrawCurrentFigure(Tetromino currentFigure, int currentFigureRow, int currentFigureColumn)
        {
            for (int row = 0; row < currentFigure.Width; row++)
            {
                for (int col = 0; col < currentFigure.Height; col++)
                {
                    if(currentFigure.Body[row, col])
                    {
                        Write("*", row + 1, col + 1);
                    }
                }
            }
        }
    }
}

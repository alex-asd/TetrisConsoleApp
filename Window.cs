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

        public Window(int gameRows, int gameCols, char gameCharacter, int informationCols)
        {
            this.gameRows = gameRows;
            this.gameCols = gameCols;
            this.gameCharacter = gameCharacter;
            this.informationCols = informationCols;

            this.consoleRows = this.gameRows + 2;
            this.consoleCols = this.gameCols + this.informationCols + 3;

            Console.Title = "Tetris v1.0";
            Console.WindowHeight = this.consoleRows + 1;
            Console.BufferHeight = this.consoleRows + 1;
            Console.WindowWidth = this.consoleCols;
            Console.BufferWidth = this.consoleCols;
            Console.CursorVisible = false;
            DrawBorder();
        }

        public void DrawBorder()
        {
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            line += new string('═', this.gameCols);

            line += "╦";
            line += new string('═', this.informationCols);
            line += "╗";
            Console.Write(line);

            for (int i = 0; i < this.gameCols; i++)
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

        public void Write(string text, int row, int col)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(text);
        }
    }
}

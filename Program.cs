using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int GameRows = 20;
            int GameCols = 10;
            int InformationCols = 11;

            Window game = new Window(GameRows, GameCols, '@', InformationCols);
            while (true) ;
        }    

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class UserInputManager : IInputManager
    {
        public GameInput ReadInput()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    return GameInput.Exit;
                }
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                {
                    return GameInput.Left;
                }
                if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                {
                    return GameInput.Right;
                }
                if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                {
                    return GameInput.Down;
                }
                if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                {
                    return GameInput.Rotate;
                }
            }

            return GameInput.None;
        }
    }
}

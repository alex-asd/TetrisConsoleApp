using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class GameInputManager : IInputManager
    {
        public GameInput ReadInput()
        {
            return GameInput.Down;
        }
    }
}

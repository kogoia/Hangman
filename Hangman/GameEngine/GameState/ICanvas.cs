using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.GameEngine.GameState
{
    interface ICanvas
    {
        IView AsView();
    }
}

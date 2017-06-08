using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Hangman.GameEngine.GameCommands;

namespace Hangman.GameEngine.GameLogic
{
    public interface IGameLogic
    {
        GameState.GameState Perfom(IGameCommand command);
    }
}

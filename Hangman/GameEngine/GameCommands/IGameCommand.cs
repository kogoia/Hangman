using System;
using System.Collections.Generic;
using System.Text;
using Hangman.GameEngine.GameRules;
using Hangman.GameEngine.GameState;

namespace Hangman.GameEngine.GameCommands
{
    public interface IGameCommand
    {
        IGameState Execute(IGameState state, IEnumerable<IGameRule> rules);
    }
}

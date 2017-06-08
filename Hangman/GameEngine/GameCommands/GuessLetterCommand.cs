using System;
using System.Collections.Generic;
using System.Text;
using Hangman.GameEngine.GameRules;
using Hangman.GameEngine.GameState;

namespace Hangman.GameEngine.GameCommands
{
    public class GuessLetterCommand : IGameCommand
    {
        public GameState.GameState Execute(IGameState state, IEnumerable<IGameRule> rules)
        {
            throw new NotImplementedException();
        }
    }
}

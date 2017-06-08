using System;
using System.Collections.Generic;
using System.Text;
using Hangman.GameEngine.GameCommands;
using Hangman.GameEngine.GameRules;

namespace Hangman.GameEngine.GameLogic
{
    public class GameLogic : IGameLogic
    {
        public GameState.GameState Perfom(IGameCommand command)
        {
            return command.Execute(new GameState.GameState(), new List<IGameRule>());
        }
    }
}

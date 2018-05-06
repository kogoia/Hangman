using System.Collections.Generic;

namespace Hangman.Old.Old.GameEngine.GameCommands
{
    public interface IGameCommand
    {
        GameState.GameState Execute(IGameState state, IEnumerable<IGameRule> rules);
    }
}

using Hangman.Infrastructure;
using Hangman.Periphery;

namespace Hangman.GameEngine
{
    public interface IGameEngine
    {
        ITarget<GameState.GameState> Run(ISource<char> commandSource);
    }
}

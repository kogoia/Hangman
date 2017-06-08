using Hangman.GameEngine.GameState;
using Hangman.Infrastructure;
using Hangman.Periphery;

namespace Hangman.GameEngine
{
    public interface IGameEngine
    {
        ITarget<IGameState> Run(ISource<char> commandSource);
    }
}

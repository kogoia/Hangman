using Hangman.GameEngine.GameState;
using Hangman.Infrastructure;
using Hangman.Periphery;
using System;

namespace Hangman.GameEngine
{
    public interface IGameEngine
    {
        IObservable<IGameState> Run(ISensor<char> commandSource);
    }
}

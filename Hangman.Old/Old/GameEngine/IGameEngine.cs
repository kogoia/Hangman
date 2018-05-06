using System;
using Hangman.Old.GameEngine.GameState;
using Hangman.Old.Old.Periphery;

namespace Hangman.Old.Old.GameEngine
{
    public interface IGameEngine
    {
        IObservable<IGameState> Run(ISensor<char> commandSource);
    }
}

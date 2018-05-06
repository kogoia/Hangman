using System;

namespace Hangman.Old.GameEngine
{
    public interface IGameEngine
    {
        IObservable<IGameState> Run(ISensor<char> commandSource);
    }
}

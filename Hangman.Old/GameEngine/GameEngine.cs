using System;

namespace Hangman.Old.GameEngine
{
    public class GameEngine : IGameEngine
    {
        public GameEngine()
        {
            
        }

        public IObservable<IGameState> Run(ISensor<char> commandSource)
        {
            throw new NotImplementedException();
        }
    }
}

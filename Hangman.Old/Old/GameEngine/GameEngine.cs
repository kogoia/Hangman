using System;
using Hangman.Old.GameEngine.GameState;
using Hangman.Old.Old.Periphery;

namespace Hangman.Old.Old.GameEngine
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

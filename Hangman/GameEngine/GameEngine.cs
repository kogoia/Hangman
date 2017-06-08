using System;
using Hangman.GameEngine.GameLogic;
using Hangman.GameEngine.GameState;
using Hangman.Infrastructure;
using Hangman.Periphery;

namespace Hangman.GameEngine
{
    public class GameEngine : IGameEngine
    {
        public GameEngine()
        {
            
        }

        public ITarget<IGameState> Run(ISource<char> commandSource)
        {
            throw new NotImplementedException();
        }
    }
}

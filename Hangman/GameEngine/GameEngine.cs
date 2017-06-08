using System;
using Hangman.GameEngine.GameLogic;
using Hangman.Infrastructure;
using Hangman.Periphery;

namespace Hangman.GameEngine
{
    public class GameEngine : IGameEngine
    {
        public GameEngine()
        {
            
        }

        public ITarget<GameState.GameState> Run(ISource<char> commandSource)
        {
            throw new NotImplementedException();
        }
    }
}

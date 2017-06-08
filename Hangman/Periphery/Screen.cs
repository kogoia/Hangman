using System;
using System.Collections.Generic;
using System.Text;
using Hangman.GameEngine.GameState;

namespace Hangman.Periphery
{
    public class Screen : IDisplay
    {
        public IObserver<GuessedWord> Target()
        {
            throw new NotImplementedException();
        }
    }
}

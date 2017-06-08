using System;
using System.Collections.Generic;
using System.Text;
using Hangman.GameEngine;
using Hangman.GameEngine.GameState;
using Hangman.Infrastructure;

namespace Hangman
{
    public class Hangman : ISource<GuessedWord>
    {
        private readonly IGameEngine _engine;

        public Hangman(IGameEngine engine, )
        {
            _engine = engine;
        }

        public IObservable<GuessedWord> Source()
        {
            throw new NotImplementedException();
        }
    }
}

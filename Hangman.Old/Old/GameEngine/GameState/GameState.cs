using System;
using System.Collections.Generic;

namespace Hangman.Old.Old.GameEngine.GameState
{
    public class GameState : IGameState
    {
        private readonly IEnumerable<char> _guessedLetters;
        private readonly IEnumerable<char> _notGuessedLetters;
        private readonly IEnumerable<char> _assumedLetters;
        private readonly IEnumerable<char> _conceivedWord;

        public GameState()
        {
            
        }

        public IView AsView()
        {
            throw new NotImplementedException();
        }

        public IView AsView(ICanvas canvas)
        {
            return _guessedLetters.SelectMany(l => canvas.Pint(l));
        }
    }
}

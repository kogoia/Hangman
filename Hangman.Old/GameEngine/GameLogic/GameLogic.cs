using System.Collections.Generic;

namespace Hangman.Old.GameEngine.GameLogic
{
    public class GameLogic : IGameLogic
    {
        public GameState.GameState Perfom(IGameCommand command)
        {
            

            new GameStep(
                new CheckedForCompliance(
                    new AssumedLetter("A"),
                    new ConceivedWord(
                        new Words()
                    )
                )
            )

            new GuessedLetter()
            new NotGuessedLetter()

            _conceivedWord.Contains(new GuessedLetter());
            return command.Execute(new GameState.GameState(), new List<IGameRule>());
        }
    }
}

namespace Hangman.Old.Views
{
    public class GameView : IView
    {
        private readonly IView _conceivedWordView;
        private readonly IView _guessedLettersView;
        private readonly IView _notGuessedLetters;
        private readonly IView _assumedLetters;
        public GameView(
            IView conceivedWordView, 
            IView guessedLettersView,
            IView notGuessedLetters,
            IView assumedLetters)
        {
            _conceivedWordView = conceivedWordView;
            _guessedLettersView = guessedLettersView;
            _notGuessedLetters = notGuessedLetters;
            _assumedLetters = assumedLetters
        }

        public string View()
        {
            return $@"
{_conceivedWordView.View()}
{_guessedLettersView.View()}
{_notGuessedLetters.View()}
{_assumedLetters.View()}
";
        }
    }
}

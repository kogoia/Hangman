namespace Hangman.Old.Old.GameEngine.GameState
{
    public class GameStateView : IView
    {

        public GameStateView(IGameState gameState)
        {

        }

        public string View()
        {
            return new GameView(
                        new ConceivedWordView(gameState)
                   ).View();
        }
    }
}

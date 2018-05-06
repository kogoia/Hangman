namespace Hangman.Old.GameEngine.GameLogic
{
    public interface IGameLogic
    {
        GameState.GameState Perfom(IGameCommand command);
    }
}

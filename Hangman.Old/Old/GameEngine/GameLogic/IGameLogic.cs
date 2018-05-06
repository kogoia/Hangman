namespace Hangman.Old.Old.GameEngine.GameLogic
{
    public interface IGameLogic
    {
        GameState.GameState Perfom(IGameCommand command);
    }
}

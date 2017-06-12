using Hangman.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.GameEngine.GameState
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

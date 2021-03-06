﻿using System;

namespace Hangman.Old.Old
{
    public class Hangman : IGame
    {
        private readonly IGameEngine _engine;
        private readonly ISensor<char> _keyboard;
        private readonly IDisplay<IView> _screen;
        public Hangman(IGameEngine engine, ISensor<char> keyboard, IDisplay<IView> screen)
        {
            _engine = engine;
        }

        public void Play()
        {
            _engine
                .Run(_keyboard)
                .Select(gs => new GameStateView(gs))
                .Subscribe(_screen);
        }

        public static void Main(string[] args)
        {
            new Hangman(
                new GameEngine.GameEngine(),
                new Keyboard(
                    Console.OpenStandardInput()
                ),
                new Screen(
                    Console.OpenStandardOutput()
                )
            ).Play();
        }

    }
}

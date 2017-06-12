using System;
using System.Collections.Generic;
using System.Text;
using Hangman.GameEngine.GameState;
using Hangman.Infrastructure;
using System.IO;

namespace Hangman.Periphery
{
    public class Screen : IDisplay<IView>
    {
        private readonly StreamWriter _outputStream;

        public Screen(Stream outputStream)
        {
            _outputStream = new StreamWriter(outputStream) { AutoFlush = true };
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(IView value)
        {
            _outputStream
                .Write(
                    value.View()
                 );
        }
    }
}

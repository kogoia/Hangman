using System;
using System.IO;

namespace Hangman.Refactored
{
    public class Screen 
    {
        private readonly IObservable<string> _source;
        private readonly TextWriter _writer;
        public Screen(IObservable<string> source) 
            : this(source, Console.Out) {}
        public Screen(IObservable<string> source, TextWriter writer)
        {
            _source = source;
            _writer = writer;
        }

        public IDisposable Power()
        {
            
            return _source
                .Subscribe((line) => _writer.WriteLine(line));
        }
    }
}
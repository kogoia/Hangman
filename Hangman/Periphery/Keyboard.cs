using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;

namespace Hangman.Periphery
{
    public class Keyboard : ISensor<char>
    {
        private readonly StreamReader _reader;
        public Keyboard(Stream inputStream)
        {
            _reader = new StreamReader(inputStream);
        }
        
        public IDisposable Subscribe(IObserver<char> observer)
        {
            observer
                .OnNext(
                    _reader
                        .ReadLine()
                        .ElementAt(0)
                 );
            return Disposable.Empty;
        }
    }
}

using System;
using System.IO;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using static Hangman.Refactored.Foo;

namespace Hangman.Refactored
{
    public class Keyboard : IObservable<string>
    {
        private readonly StreamReader _input;

        public Keyboard()
            : this(Console.OpenStandardInput()) {}
        public Keyboard(Stream input)
            : this(new StreamReader(input)) { }
        public Keyboard(StreamReader input)
        {
            _input = input;
        }
        public IDisposable Subscribe(IObserver<string> observer)
        {
            return Observable
                .FromAsync(ct =>
                {
                    Output("FromAsync");
                    return _input.ReadLineAsync();
                })
                .Repeat()
                .Publish()
                .RefCount()
                .ObserveOn(Scheduler.CurrentThread)
                .SubscribeOn(Scheduler.CurrentThread)
                .Subscribe(observer);
        }
    }
}
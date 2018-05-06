using System;

namespace Hangman.Old.Infrastructure
{
    public interface ISource<out TOutput>
    {
        IObservable<TOutput> Source();
    }
}

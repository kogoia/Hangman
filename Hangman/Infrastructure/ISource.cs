using System;

namespace Hangman.Infrastructure
{
    public interface ISource<out TOutput>
    {
        IObservable<TOutput> Source();
    }
}

using System;

namespace Hangman.Old.Old.Infrastructure
{
    public interface ISource<out TOutput>
    {
        IObservable<TOutput> Source();
    }
}

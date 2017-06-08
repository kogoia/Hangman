using System;

namespace Hangman.Infrastructure
{
    public interface ITarget<in TInput>
    {
        IObserver<TInput> Target();
    }
}

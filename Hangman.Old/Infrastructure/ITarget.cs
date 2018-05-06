using System;

namespace Hangman.Old.Infrastructure
{
    public interface ITarget<in TInput>
    {
        IObserver<TInput> Target();
    }
}

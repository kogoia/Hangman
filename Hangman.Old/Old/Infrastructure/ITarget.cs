using System;

namespace Hangman.Old.Old.Infrastructure
{
    public interface ITarget<in TInput>
    {
        IObserver<TInput> Target();
    }
}

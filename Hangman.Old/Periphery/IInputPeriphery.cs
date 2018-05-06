using System;

namespace Hangman.Old.Periphery
{
    public interface IInputPeriphery<TInput> : IObserver<TInput>, IPeriphery
    {
    }
}

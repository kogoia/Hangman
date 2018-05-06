using System;

namespace Hangman.Old.Old.Periphery
{
    public interface IInputPeriphery<TInput> : IObserver<TInput>, IPeriphery
    {
    }
}

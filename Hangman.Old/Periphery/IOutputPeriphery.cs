using System;

namespace Hangman.Old.Periphery
{
    public interface IOutputPeriphery<in TInput> : IObserver<TInput>, IPeriphery
    {
    }
}

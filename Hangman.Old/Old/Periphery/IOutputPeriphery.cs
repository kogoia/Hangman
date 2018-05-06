using System;

namespace Hangman.Old.Old.Periphery
{
    public interface IOutputPeriphery<in TInput> : IObserver<TInput>, IPeriphery
    {
    }
}

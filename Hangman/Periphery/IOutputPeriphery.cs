using System;
using System.Collections.Generic;
using System.Text;
using Hangman.Infrastructure;

namespace Hangman.Periphery
{
    public interface IOutputPeriphery<in TInput> : ITarget<TInput>, IPeriphery
    {
    }
}

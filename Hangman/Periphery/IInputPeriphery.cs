using System;
using System.Collections.Generic;
using System.Text;
using Hangman.Infrastructure;

namespace Hangman.Periphery
{
    public interface IInputPeriphery<out TOutput> : ISource<TOutput>, IPeriphery
    {
    }
}

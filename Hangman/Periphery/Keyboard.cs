using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Periphery
{
    public class Keyboard : IInputPeriphery<char>
    {
        public IObservable<char> Source()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Threading;

namespace Hangman.Refactored
{
    public static class Foo
    {
        public static void Output(string str)
        {
            Console.WriteLine($"{str}, ThreadId: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
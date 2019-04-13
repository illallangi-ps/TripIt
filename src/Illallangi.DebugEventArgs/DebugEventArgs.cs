using System;

namespace Illallangi
{
    public sealed class DebugEventArgs : EventArgs
    {
        public string Message { get; }

        public DebugEventArgs(string message)
        {
            Message = message;
        }
    }
}
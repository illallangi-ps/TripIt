using System;

namespace Illallangi.TripIt
{
    public sealed class AuthorizeEventArgs : EventArgs
    {
        public string Uri { get; }
        public string Token { get; }

        public AuthorizeEventArgs(string token, string uri, params object[] args)
        {
            Uri = string.Format(uri, args);
            Token = token;
        }
    }
}
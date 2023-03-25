using System;


namespace UnityServer
{
    internal class SocketLogin : Login
    {
        public SocketLogin(string username, string password): base(username, password) {}
    }
}
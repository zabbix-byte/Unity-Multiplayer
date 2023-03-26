using System;
using System.Security.Policy;

namespace UnityServer
{
    internal class SocketLogin : Login
    {
        public SocketLogin(string username, string password): base(username, password) {}
    }
}
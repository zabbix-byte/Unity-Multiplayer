using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Configuration;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace UnityServer
{
    internal class Player
    {
        private string username;
        private string password;

        public Player(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
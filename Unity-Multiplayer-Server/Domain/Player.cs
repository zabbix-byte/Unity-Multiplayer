using System;
using System.Security.Policy;

namespace UnityServer
{
    internal class Player  
    {
        public string username;
        public string password;

        public void info_in_terminal()
        {
            Console.WriteLine($"The user: <{this.username}> has just connected!");
        }

        public string get_my_name()
        {
            return this.username;
        }
    }
}
using System;


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
            info_in_terminat();
        }

        public void info_in_terminat()
        {
            Console.WriteLine($"The user: <{this.username}> has just connected!");
        }
    }
}
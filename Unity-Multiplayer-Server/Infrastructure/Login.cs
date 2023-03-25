using System;


namespace UnityServer
{
    internal class Login
    {
        public bool is_auth = false;

        public Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                Player current_palyer = new Player(username, password);
                is_auth = true;
            }
        }
    }
}
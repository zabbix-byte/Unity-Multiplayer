using System;


namespace UnityServer
{
    internal class Login  : Player
    {
        public bool is_auth = false;

        public Login(string username, string password) : base()
        {
            if (username == "admin" && password == "123")
            {
                this.username = username;
                this.password = password;
                is_auth = true;
            }

            if (username == "user" && password == "123")
            {
                this.username = username;
                this.password = password;
                is_auth = true;
            }

            if (is_auth)
            {
                info_in_terminal();
            }
        }


    }
}
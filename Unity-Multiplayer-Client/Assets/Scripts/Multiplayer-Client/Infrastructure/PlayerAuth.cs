using System.Collections;
using System.Collections.Generic;
using System;

namespace UnityMultiplayerClient
{
    public class PlayerAuth
    {

        public PlayerAuth() {}

        public bool login(string username, string password)
        {
            /*
            POST /login
            username: your_username
            password: your_password
            */

            string body = "username:" + username + "\n" + "password:" + password;

            SendData new_send_data = new SendData("login", body);

            if (new_send_data.send_data() == "Authorized")
            {
                return true;
            }

            return false;
        }

    }
}
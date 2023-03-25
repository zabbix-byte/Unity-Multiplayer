using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityMultiplayerClient
{
    public class Player : MonoBehaviour
    {

        public string username;
        public string password;
        private bool auth = false;

        private void set_auth(bool status)
        {
            this.auth = status;
        }


        void Start()
        {
            PlayerAuth player_auth = new PlayerAuth();
            auth = player_auth.login(this.username, this.password);
        }

    }
}


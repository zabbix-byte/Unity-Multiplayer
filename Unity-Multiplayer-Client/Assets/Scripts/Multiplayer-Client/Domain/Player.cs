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
        PlayerAuth player_auth = new PlayerAuth();

        private void set_auth(bool status)
        {
            this.auth = status;
        }


        void Start()
        {
            auth = player_auth.login(this.username, this.password);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
            Debug.Log(player_auth.get_my_name());
            }
        }

    }
}


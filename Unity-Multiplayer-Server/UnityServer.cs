using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Configuration;

namespace UnityServer
{
    internal class Server
    {
        
        public static int PORT = Int32.Parse(ConfigurationManager.AppSettings.Get("PORT") ?? "5000");

        static void Main(string[] args)
        {

            byte[] data = new byte[1024];
            SocketLogin new_login = new SocketLogin("", "");
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORT);
            UdpClient newsock = new UdpClient(ipep);
            Console.WriteLine("Running Server on port "+ PORT+ ", waiting for clients..");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {

                data = newsock.Receive(ref sender);
                string current_petition = Encoding.ASCII.GetString(data, 0, data.Length);

                if (Serializer.get_method(current_petition) == "POST" && Serializer.get_action(current_petition) == "/login")
                {
                    IDictionary<string, string> credentials =  Serializer.get_body(current_petition);

                    new_login = new SocketLogin(credentials["username"], credentials["password"]);
                    
                }
                if (new_login.is_auth)
                {
                    if (Serializer.get_method(current_petition) == "GET" && Serializer.get_action(current_petition) == "/get_my_name")
                    {
                        Console.Write(new_login.get_my_name());
                        data = Encoding.ASCII.GetBytes(new_login.get_my_name());
                        newsock.Send(data, data.Length, sender);
                    }

                }
            }

        }
    }
}
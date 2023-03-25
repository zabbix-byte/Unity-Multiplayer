using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Configuration;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace UnityServer
{
    internal class Serializer
    {
        static public string get_method(string query)
        {
            Console.WriteLine(query.Split(" "));
            return "";
        }

        static public string get_atributes(string query)
        {
            return "";
        }

        static public string get_body(string query)
        {
            return "";
        }
    }
}
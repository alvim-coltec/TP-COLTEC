using System;
using Sockets;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Sockets
{
    internal class Log
    {
        public static void logMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void logConection(TcpClient client)
        {
            Console.WriteLine("Cliente conectado: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
        }
    }
}

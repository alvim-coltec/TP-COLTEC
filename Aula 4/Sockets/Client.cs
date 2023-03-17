using System;
using System.IO;
using System.Net.Sockets;

public class MicroClient
{
    public const string host = "10.0.0.61";
    public const int port = 88;

    public static void Main(string[] args)
    {
        TcpClient client = new TcpClient(host, port);
        StreamReader inputStream = new StreamReader(client.GetStream());
        StreamWriter outputStream = new StreamWriter(client.GetStream());
        outputStream.AutoFlush = true;

        while (true)
        {
            if (Console.ReadLine() != null)
            {
                outputStream.WriteLine(Console.ReadLine());
            }
            Console.WriteLine(inputStream.ReadLine());
        }
    }
}

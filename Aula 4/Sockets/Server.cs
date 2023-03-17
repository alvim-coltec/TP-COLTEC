using Sockets;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class MicroServer
{
    public const int port = 88;

    public static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Log.logConection(client);

                Thread t = new Thread(new TreatClient(client).run);
                t.Start();
            }
    }
}

public class TreatClient
{
    private TcpClient client;

    public TreatClient(TcpClient client)
    {
        this.client = client;
    }

    public void run()
    {
        try
        {
            StreamReader inputStream = new StreamReader(client.GetStream());
            if (inputStream.ReadLine() != null)
            {
                Log.logMessage(client.Client.RemoteEndPoint.ToString() + ": " + inputStream.ReadLine());
            }
        }
        catch (IOException e) { }
    }
}
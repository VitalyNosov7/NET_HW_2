using System.Net;
using System.Net.Sockets;
using System.Text;

public class UdpServer
{
    private const int Port = 12345;
    
    private UdpClient server;

    public UdpServer()
    {
        server = new UdpClient(Port);
    }

    public void Start()
    {
        while (true)
        {

            if (Console.KeyAvailable == true)
            {
                server.Close();
                var key = Console.ReadKey(true).Key;

                Console.WriteLine(key);

                Console.WriteLine("Server stoped!");
                Environment.Exit(0);
            }

            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, Port);

            byte[] data = server.Receive(ref clientEndPoint);

            string message = Encoding.ASCII.GetString(data);

            Console.WriteLine("Received message from {0}: {1}", clientEndPoint.Address, message);

            BroadcastMessage(message, clientEndPoint);

        }
    }

    private void BroadcastMessage(string message, IPEndPoint excludeEndPoint)
    {
        server.Send(Encoding.UTF8.GetBytes(message), message.Length, excludeEndPoint);
    }
}
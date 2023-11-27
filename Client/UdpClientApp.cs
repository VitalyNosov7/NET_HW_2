using System.Net;
using System.Net.Sockets;
using System.Text;

class UdpClientApp
{
    private const int Port = 12345;
    private IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
    private UdpClient client;
    private string? Name = string.Empty;
    private string? UserMessage = string.Empty;
    private string? FullMessage = string.Empty;
    private byte[] Data;

    public UdpClientApp()
    {
        client = new UdpClient();
        SetName();
    }

    public void SetName()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();
    }

    public void Start()
    {

        Console.WriteLine("Connected to server. Enter message:");

        while (true)
        {
            UserMessage = Console.ReadLine();

            if (UserMessage == "Exit")
            {
                UserMessage = $"The user {Name} has left the application.!";

                Name = "";

                SendMessage();

                client.Close();
                Environment.Exit(0);
            }
            SendMessage();
        }
    }

    public void SendMessage()
    {
        FullMessage = $"{Name}: {UserMessage}";
        Data = Encoding.ASCII.GetBytes(FullMessage);
        client.Send(Data, Data.Length, serverEndPoint);
    }
}
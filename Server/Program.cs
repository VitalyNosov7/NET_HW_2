
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpServer server = new UdpServer();
            server.Start();
        }
    }
}
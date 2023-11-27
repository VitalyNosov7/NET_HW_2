namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdpClientApp clientApp = new UdpClientApp();
            clientApp.Start();
        }
    }
}
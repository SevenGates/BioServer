namespace BioServer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncSocketListener server = new AsyncSocketListener();
            server.StartListening();
        }
    }
}

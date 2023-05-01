using TCPClient_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client();

        client.handlerAsync();
    }
}

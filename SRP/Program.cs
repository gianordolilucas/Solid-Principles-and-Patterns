using SRP.utils;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("name","email");
            Notify notify = new Notify();
            notify.NotifyClient(client1);
            
        }
    }
}

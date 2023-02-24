using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.utils
{
    internal class Notify
    {
        public void NotifyClient (Client client)
        {
            Console.WriteLine("Notificando um cliente: "+client.ReadClient());
        }
    }
}

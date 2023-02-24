using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.utils
{
    internal class Client
    {
        protected string name { get; set; }
        private string email { get; set; }

        public Client(string name, string email)
        {
            this.name = name;
            this.email = name;
        }

        public void UpdateClient () { }
        public void DeleteClient () { }
        public string ReadClient() 
        { 
            return this.name;
        }

    }
}

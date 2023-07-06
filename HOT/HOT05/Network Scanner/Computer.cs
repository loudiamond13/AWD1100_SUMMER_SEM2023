using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Scanner
{
    public class Computer
    {
        private string      _name = "";
        private string      _ipAddress = "";
        private string       _services= "";


        public Computer(string name, string ipAddress, string services ) 
        {
            _ipAddress = ipAddress;
            _name = name;
          _services = services;
        
        }

        public string Name 
        {
            get { return _name; }
        }

        public string IpAddress
        {
            get { return _ipAddress; }
        }

        public string Services
        {
            get { return _services; }
        }


        public override string ToString() 
        {
            
            return _name + _ipAddress + _services; 
        
        }

    }
}

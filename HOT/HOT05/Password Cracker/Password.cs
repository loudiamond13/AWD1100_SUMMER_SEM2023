using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Cracker
{
    public class Password
    {
        private string _raw;
        private string _hash;
        

        public Password()
        {
            // default 
        }

        public Password(string raw, string hash)
        {
            _raw = raw;
            _raw = hash;
        }

        public string Raw { get { return _raw; } }

        public string Hash { get { return _hash; } }

        public override string ToString() 
        {
            
            return Raw;
        }
    }
}

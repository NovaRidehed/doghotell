using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Address
    {
        public string gatuAdress;
        public string stad;
        public string postnummer;

        public Address(string gA, string s, string pN)
        {
            gatuAdress = gA;
            stad = s;
            postnummer = pN;
        }
    }
}

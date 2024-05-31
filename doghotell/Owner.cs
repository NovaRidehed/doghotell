using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Owner
    {
        public string firstName;
        public string lastName;
        public Address adress;

        public Owner(string fN, string lN, Address a)
        {
            firstName = fN;
            lastName = lN;
            adress = a;
        }
        internal string GetAddress()
        {
            string gA = adress.gatuAdress;
            string s = adress.stad;
            string pN = adress.postnummer;
            string address = gA + ", "+ s + ", " + pN;
            return address;
        }
    }
}

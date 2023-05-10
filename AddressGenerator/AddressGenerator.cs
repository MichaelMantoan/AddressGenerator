using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator
{
    public class AddressGenerator : IAddress
    {
         int[] _bits;
        int _bitssubnet;

        public AddressGenerator(int[] bits, int subnetbit)
        {
            if (bits.Length != 32)
            {
                throw new ArgumentException("Il numero di bit deve essere esattamente 32.");
            }

            _bits = bits;
            _bitssubnet = subnetbit;
        }

        public string generateIPV4()
        {
            byte[] bytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                int startIndex = i * 8;
                int endIndex = startIndex + 8;
                int decimalValue = Convert.ToInt32(string.Join("", _bits.Skip(startIndex).Take(8)), 2);
                bytes[i] = Convert.ToByte(decimalValue);
            }

            return new IPAddress(bytes).ToString();
        }
        public string generateSubnet()
        {
            uint subnetMask = 0xFFFFFFFF << (32 - _bitssubnet);
            subnetMask = (uint)IPAddress.HostToNetworkOrder((int)subnetMask);
            return  new IPAddress(subnetMask).ToString();
        }




    }
}
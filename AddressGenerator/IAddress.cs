using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator
{
    internal interface IAddress
    {
        string generateIPV4();
        string generateSubnet();
    }
}

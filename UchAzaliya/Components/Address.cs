using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchAzaliya.Bases
{
    public partial class Address
    {
        public string FullAddress
        {
            get
            {
                return $"{City} {Street} {HouseNumber}";
            }
        }
    }
}

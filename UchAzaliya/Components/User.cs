using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchAzaliya.Bases
{
    public partial class User
    {
        public string FullName
        {
            get
            {
                return $"{Name} {Surname} {Patronymic}";
            }
        }
    }
}

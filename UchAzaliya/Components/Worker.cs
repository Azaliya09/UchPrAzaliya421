using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UchAzaliya.Bases
{
    public partial class Worker
    {
        public int Age
        {
            get
            {
                if(DateBorn == null)
                    return 0;
                return DateTime.Now.Year - DateBorn.Value.Year;
            }
        }

        public string Operations
        {
            get
            {
                string operations = "";
                var list = WorkerProcess.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == WorkerProcess.Count - 1)
                        operations += list[i].Name_Process.ToString() + ".";
                    else
                        operations += list[i].Name_Process.ToString() + ", ";
                }
                return operations;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cerchio
    {
        public int raggio { get; set; }

        public Cerchio(int r) 
        {
            raggio = r;
        }

        public override string ToString()
        {
            return string.Format("Cerchio R = {0}", raggio);
        }
    }
}

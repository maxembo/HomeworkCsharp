using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyApp
{
    public class Rally
    {
        string EventName { get; set; }

        public int N1 { get; set; }

        public int N2 { get; set; }

        public Rally(string eventName, int n1, int n2)
        {
            EventName = eventName;
            N1 = n1;
            N2 = n2;
        }

        public virtual double getQ() => Math.Round((double)N1 / N2, 2);

        public override string ToString() => ($"Q = {getQ()}");
    }
}

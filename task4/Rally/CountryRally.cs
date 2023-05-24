using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyApp
{
    public class CountryRally : Rally
    {
        public int P { get; set; }
        public CountryRally(string eventName, int n1, int n2, int p)
            : base(eventName, n1, n2)
        {
            P = p;
        }

        public override double getQ()
        {
            double Q = base.getQ();

            if (P > 0)
                Q = Q + (float)P / N2;

            return Math.Round(Q, 2);
        }

        public override string ToString() => ($"Qp = {getQ()}");
    }
}

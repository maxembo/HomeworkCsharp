using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    internal interface SpaceObject
    {
        string SourcePowerType { get; set; }

        bool IsActive();
    }
}

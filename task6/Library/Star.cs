using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    abstract class Star: SpaceObject
    {
        public abstract double Temperature { get; set; }
        public abstract double Power { get; set; }
        public abstract double LifeTime { get; set; }
        public abstract string SourcePowerType { get; set; }


        public Star() { }

        public abstract bool IsActive();
        public abstract bool Moving();
        public abstract bool Explode();
    }
}

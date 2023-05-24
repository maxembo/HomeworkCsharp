using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    internal class RedGiant: Star
    {
        private string consellationName;
        private string name;
        private string starType;
        private double temperature;
        private double power;
        private double lifeTime;
        private string sourcePowerType;
        private bool moving = false;
        private bool explode = false;

        private bool active = false;
        public RedGiant(): base() { }

        public string ConsellationName
        {
            get
            {
                return consellationName;
            }
            set
            {
                consellationName = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string StarType
        {
            get
            {
                return StarType;
            } set
            {
                StarType = value;
            }
        }
        public override double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        public override double Power {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
        public override double LifeTime
        {
            get
            {
                return lifeTime;
            }
            set
            {
                lifeTime = value;
            }
        }
        public override string SourcePowerType 
        {
            get
            {
                return sourcePowerType;
            }
            set
            {
                sourcePowerType = value;
            }
        }


        public override bool IsActive()
        {
            return active;
        }

        public override bool Moving()
        {
            this.moving = true;
            return moving;
        }

        public override bool Explode()
        {
            this.explode = true;
            return explode;
        }

        public string toString()
        {
            return string.Format("Созвездие: {0}| Продолжительность жизни: {1}| Тепература: {2}| Мощность: {3}| Название: {4}|",
                this.consellationName, this.lifeTime, this.temperature, this.power, this.name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensoren_Ampel
{
    internal class Sensor
    {
        double temperatur;
        bool isErreichbar = true;

        public double Temperatur { get => temperatur; set => temperatur = value; }
        public bool IsErreichbar { get => isErreichbar; set => isErreichbar = value; }
        public Sensor(double t)
        {
            this.Temperatur = t;
        }

    }
}

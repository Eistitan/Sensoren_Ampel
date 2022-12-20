using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensoren_Ampel
{
    internal class Serverraum
    {
        Sensor[] sensoren; 

        public Serverraum(double t1, double t2, double t3)
        {
            Sensor s1 = new Sensor(t1);
            Sensor s2 = new Sensor(t2);
            Sensor s3 = new Sensor(t3);
            Sensor[] sensoren = { s1, s2, s3 };
            this.sensoren = sensoren;
        }
        public enum Zustand
        {
            Green,
            Yellow,
            Red,
        }

        public Zustand Messe_Werte()
        {
            var farbe = Zustand.Green;
            for (int i = 0; i < sensoren.Length; i++)
            {
                if (farbe != Zustand.Red)
                {
                    if (sensoren[i].IsErreichbar)
                    {
                        if (sensoren[i].Temperatur < 20)
                            farbe = Zustand.Yellow;
                        if (sensoren[i].Temperatur > 30)
                            farbe = Zustand.Yellow;
                        if (sensoren[i].Temperatur > 35)
                            return Zustand.Red;
                    }
                    else
                        return Zustand.Red;
                }
            }
            return farbe;
        }
        
    }
}

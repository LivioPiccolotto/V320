using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHome.Test
{
    internal class WetterdatenMock
    {
        public class Wettersensor
        {
            private Random random;
            private double currentTemp;
            private const int MAX_TEMP = 35;
            private const int MIN_TEMP = -25;
            public Wettersensor(double temp, double wind, bool rain)
            {
                this.currentTemp = temp;
                this.Windgeschwindigkeit = wind;
                this.Regen = rain;

                var wettersensor = new Wettersensor(20, 10, false); // Temperatur: 20°C, Windgeschwindigkeit: 10 km/h, kein Regen
                var wetterdaten = wettersensor.GetWetterdaten();
            }

            public Wetterdaten GetWetterdaten()
            {
                var rand = new Random().NextDouble();

                var wind = this.Windgeschwindigkeit + Math.Round(35d * rand, 1);
                if (wind > 70) wind = 70; // Begrenzung der Windgeschwindigkeit auf max. 70 km/h

                this.currentTemp += Math.Round(rand * (this.Regen ? -1 : 1), 1);
                if (this.currentTemp < MIN_TEMP) this.currentTemp = MIN_TEMP;
                if (this.currentTemp > MAX_TEMP) this.currentTemp = MAX_TEMP;

                return new Wetterdaten { Aussentemperatur = this.currentTemp, Windgeschwindigkeit = wind, Regen = this.Regen };
            }

            public double Windgeschwindigkeit { get; set; }
            public bool Regen { get; set; }
        }
    }
}

// Ich habe nun probiert einen neue Wetterdateneingabe zu machen. Diese ist nun aber nicht zufällig, sondern mann kann sie selber bestimmen. So kann ich schauen wie das System reagiert und ob es richtig heitzt. 
    

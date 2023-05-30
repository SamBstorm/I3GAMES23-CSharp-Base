using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMethode_01.Structs
{
    public struct Fahrenheit
    {
        public double temperature;

        public Celsius Convert()
        {
            Celsius c = new Celsius();
            c.temperature = (temperature - 32) * 5 / 9;
            return c;
        }
    }
}

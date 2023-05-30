using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMethode_01.Structs
{
    public struct Celsius
    {
        public double temperature;

        public Fahrenheit Convert() {
            Fahrenheit f = new Fahrenheit();
            f.temperature = (temperature * 9 / 5) + 32;
            return f;
        }
    }
}

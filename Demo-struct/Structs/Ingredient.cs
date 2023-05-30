using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_struct.Structs
{
    public struct Ingredient
    {
        public string nom;
        public string unite_mesure;
        public int quantite;

        public string GetInfo()
        {
            return $"{nom} : {quantite} {unite_mesure}";
        }
    }
}

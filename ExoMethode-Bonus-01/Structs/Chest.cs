using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMethode_Bonus_01.Structs
{
    public struct Chest
    {
        public string type;
        public int quantity;

        public void GetContent()
        {
            if (quantity > 0)
            {
                quantity = 0;
            }
        }
    }
}

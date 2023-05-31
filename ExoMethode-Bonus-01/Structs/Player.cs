using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMethode_Bonus_01.Structs
{
    public struct Player
    {
        public Dictionary<string, int> inventory;

        public bool Loot(ref Chest chest)   //le mot-clé ref permet à notre structure de ne pas être une copie
                                            //le mot-clé in protège en lecture seule le paramètre
                                            //ATTENTION : les mots-clé ref et in ne peuvent cohabiter....
        {
            if(chest.quantity == 0) return false;

            inventory ??= new Dictionary<string, int>();

            if (inventory.ContainsKey(chest.type))
            {
                //int oldQuantity = inventory[chest.type];
                //inventory[chest.type] = oldQuantity + chest.quantity;


                inventory[chest.type] += chest.quantity;
            }
            else
            {
                inventory.Add(chest.type, chest.quantity);
            }

            //chest.quantity = 0;   //Si on aurait mis le mot clé in : Donne une erreur car les variables de chest sont protégées
            chest.GetContent();     //Pas de soucis avec GetContent(), c'est la méthode du chest lui-même qui change la variable quantity

            return true;
        }

        public void ShowInventory()
        {
            Console.WriteLine("Contenu de l'inventaire :");
            if (inventory is null || inventory.Count == 0) Console.WriteLine("L'inventaire est vide");
            else
            {
                foreach (KeyValuePair<string, int> kvp in inventory)
                {
                    if (kvp.Value > 0) Console.WriteLine($"Il vous reste {kvp.Value} {kvp.Key}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_struct.Structs
{
    public struct Recette
    {
        #region champs/variables membres
        public string nom;
        /// <summary>
        /// En minute.
        /// </summary>
        public int duree;
        /// <summary>
        /// Niveau de 0 à 10
        /// </summary>
        public int difficulte;
        public List<Ingredient> ingredients;
        public List<string> etapes;
        #endregion

        #region Propriétés
        //Pas encore vu
        #endregion

        #region Constructeurs et destructeur
        //Pas encore vu
        #endregion

        #region Méthodes
        public void AjoutIngredient(string nom, string unite_mesure, int quantite)
        {
            if (ingredients is null)
            {
                ingredients = new List<Ingredient>();
            }

            //opérateur "Coalesce" ?? : récupère la valeur de gaauche si non-null, sinon prends celle de droite
            //ingredients = ingredients ?? new List<Ingredient>(); 
            //OU
            //ingredients ??= new List<Ingredient>();

            Ingredient ingredient;
            ingredient.nom = nom;
            ingredient.unite_mesure = unite_mesure;
            ingredient.quantite = quantite;

            ingredients.Add(ingredient);
        }

        public void Affiche_Ingredients()
        {
            Console.WriteLine($"Pour un {nom}, il nous faut :");
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"\t-\t{ingredient.GetInfo()}");
            }
        }
        #endregion

    }
}

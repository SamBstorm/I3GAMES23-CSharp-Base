using Demo_struct.Structs;

namespace Demo_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recette recette_1 = new Recette();
            recette_1.nom = "Crumble au pommes";
            recette_1.duree = 60;
            recette_1.difficulte = 2;
            //recette_1.ingredients = new List<Ingredient>();

            //Ingredient ingredient_1;
            //ingredient_1.nom = "Pomme";
            //ingredient_1.unite_mesure = "pièce";
            //ingredient_1.quantite = 3;
            //Ingredient ingredient_2;
            //ingredient_2.nom = "Beurre";
            //ingredient_2.unite_mesure = "gramme";
            //ingredient_2.quantite = 50;
            //Ingredient ingredient_3;
            //ingredient_3.nom = "Farine";
            //ingredient_3.unite_mesure = "gramme";
            //ingredient_3.quantite = 60;
            //Ingredient ingredient_4 = ingredient_3;     //copie des valeurs de ingredient_3
            //ingredient_4.nom = "Sucre";                 //changement de valeur pour le nom d'ingredient_4
            //                                            //Attention, le changement se fait que sur ingredient_4
            //                                            //ingredient_3 ne change pas!

            //recette_1.ingredients.Add(ingredient_1);
            //recette_1.ingredients.Add(ingredient_2);
            //recette_1.ingredients.Add(ingredient_3);
            //recette_1.ingredients.Add(ingredient_4);
            //OU
            //recette_1.ingredients.AddRange(new Ingredient[] { ingredient_1, ingredient_2, ingredient_3, ingredient_4 });

            recette_1.AjoutIngredient("Pomme","pièce",3);
            recette_1.AjoutIngredient("Beurre","gramme",50);
            recette_1.AjoutIngredient("Farine","gramme",60);
            recette_1.AjoutIngredient("Sucre","gramme",60);
            recette_1.AjoutIngredient(
                new Ingredient { nom = "Lait", unite_mesure = "décilittre", quantite = 1 }
                );

            recette_1.Affiche_Ingredients();
        }
    }
}
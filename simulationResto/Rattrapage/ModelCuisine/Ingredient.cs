namespace Rattrapage.ModelCuisine
{
    public class Ingredient
    {
        public string nomIngredient;
        public int quantiteIngredient;

        public Ingredient(string nom, int quantite)
        {
            nomIngredient = nom;
            quantiteIngredient = quantite;
        }

    }
}
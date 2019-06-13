using System.Collections.Generic;

namespace Rattrapage.ModelCuisine
{
    public class Recette
    {
        public string nomRecette;
        public List<Ingredient> listIngredients;
        public int tmpsCuisson;
        public int tmpsPreparation;
        public string typeP;

        public Recette(string nom, List<Ingredient> ingredients, int tempsCuisson, int tempsPreparation, string type)
        {
            nomRecette = nom;
            listIngredients = ingredients;
            tmpsCuisson = tempsCuisson;
            tmpsPreparation = tempsPreparation;
            typeP = type;
        }
    }
}
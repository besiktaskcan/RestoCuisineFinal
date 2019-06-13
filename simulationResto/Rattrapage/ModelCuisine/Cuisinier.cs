using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rattrapage.ModelCuisine
{
    public class Cuisinier
    {
        public void Cuisiner(Recette recette)
        {
            Objets objets = new Objets();

            Thread.Sleep(recette.tmpsCuisson + recette.tmpsPreparation);

            foreach (Ingredient ingredient in recette.listIngredients)
            {
                ingredient.quantiteIngredient--;
            }
        }
    }
}

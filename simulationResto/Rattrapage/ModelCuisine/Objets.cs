using System.Collections.Generic;
using System.Linq;

namespace Rattrapage.ModelCuisine
{
    class Objets
    {
        public static List<Recette> recettes = new List<Recette>();
        public static List<Ingredient> ingredients = new List<Ingredient>();


        public Objets()
        {

        }

        public void Preparation()
        {
            //Ingredients
            Ingredient lait = new Ingredient("lait", 150);
            ingredients.Add(lait);

            Ingredient saucetomate = new Ingredient("saucetomate", 150);
            ingredients.Add(saucetomate);

            Ingredient creme = new Ingredient("creme", 150);
            ingredients.Add(creme);

            Ingredient chocolat = new Ingredient("chocolat", 150);
            ingredients.Add(chocolat);

            Ingredient gruyere = new Ingredient("gruyere", 150);
            ingredients.Add(gruyere);

            Ingredient vanille = new Ingredient("vanille", 150);
            ingredients.Add(vanille);

            Ingredient oeuf = new Ingredient("oeuf", 150);
            ingredients.Add(oeuf);

            Ingredient chou = new Ingredient("chou pommé blanc", 150);
            ingredients.Add(chou);

            Ingredient carotte = new Ingredient("carotte", 150);
            ingredients.Add(carotte);

            Ingredient pates = new Ingredient("pates", 150);
            ingredients.Add(pates);

            Ingredient riz = new Ingredient("riz", 150);
            ingredients.Add(riz); ;

            Ingredient poulet = new Ingredient("poulet", 150);
            ingredients.Add(poulet);

            Ingredient boeuf = new Ingredient("boeuf", 150);
            ingredients.Add(boeuf);

            Ingredient poivre = new Ingredient("poivre", 150);
            ingredients.Add(poivre);

            Ingredient cremefraiche = new Ingredient("creme fraiche", 150);
            ingredients.Add(cremefraiche);

            Ingredient biscuit = new Ingredient("biscuit", 150);
            ingredients.Add(biscuit);

            Ingredient cafe = new Ingredient("café", 150);
            ingredients.Add(cafe);

            Ingredient farine = new Ingredient("farine", 150);
            ingredients.Add(farine);

            Ingredient tomate = new Ingredient("tomate", 150);
            ingredients.Add(tomate);

            Ingredient cacao = new Ingredient("cacao", 150);
            ingredients.Add(cacao);

            Ingredient mozzarella = new Ingredient("mozzarella", 150);
            ingredients.Add(mozzarella);

            Ingredient poisson = new Ingredient("poisson", 150);
            ingredients.Add(poisson);

            Ingredient pommedeterre = new Ingredient("pomme de terre", 150);
            ingredients.Add(pommedeterre);

            Ingredient chapelure = new Ingredient("chapelure", 150);
            ingredients.Add(chapelure);

            Ingredient pateBrise = new Ingredient("pâte brisé", 150);
            ingredients.Add(pateBrise);

            Ingredient beurre = new Ingredient("beurre", 150);
            ingredients.Add(beurre);

            Ingredient pomme = new Ingredient("pomme", 150);
            ingredients.Add(pomme);

            Ingredient sucre = new Ingredient("sucre en poudre", 150);
            ingredients.Add(sucre);


            //Recettes
            Recette nuggetsfrite = new Recette("nuggets et frites", new List<Ingredient> { pommedeterre, oeuf, poulet, chapelure, farine }, 4000, 1000, "PLAT");
            recettes.Add(nuggetsfrite);

            Recette fishandchips = new Recette("fish and chips", new List<Ingredient> { poisson, pommedeterre }, 3000, 2000, "PLAT");
            recettes.Add(fishandchips);

            Recette bolognaise = new Recette("spaghetti bolognaise", new List<Ingredient> { pates, boeuf, saucetomate }, 3000, 2000, "PLAT");
            recettes.Add(bolognaise);

            Recette crepechocolat = new Recette("crêpe au chocolat", new List<Ingredient> { sucre, farine, oeuf, cacao, lait }, 1000, 2000, "DESSERT");
            recettes.Add(crepechocolat);

            Recette glacechocolat = new Recette("glace au chocolat", new List<Ingredient> { chocolat, sucre, cacao, cremefraiche, lait }, 1000, 2000, "DESSERT");
            recettes.Add(glacechocolat);

            Recette tiramisu = new Recette("tiramisu", new List<Ingredient> { cafe, cacao, sucre, biscuit }, 1000, 2000, "DESSERT");
            recettes.Add(tiramisu);

            Recette gateauvanille = new Recette("gateau à la vanille", new List<Ingredient> { vanille, oeuf, farine }, 1000, 2000, "DESSERT");
            recettes.Add(gateauvanille);

            Recette tartepomme = new Recette("tarte aux pommes", new List<Ingredient> { pateBrise, oeuf, pomme, sucre }, 1000, 2000, "DESSERT");
            recettes.Add(tartepomme);

            Recette oeufscoque = new Recette("oeufs à la coque", new List<Ingredient> { oeuf, beurre }, 500, 1500, "ENTREE");
            recettes.Add(oeufscoque);

            Recette rizpoulet = new Recette("riz au poulet", new List<Ingredient> { riz, poulet, creme }, 3000, 2000, "PLAT");
            recettes.Add(rizpoulet);

            Recette oeufcocotte = new Recette("oeuf cocotte", new List<Ingredient> { oeuf, gruyere, cremefraiche, poivre }, 500, 1500, "ENTREE");
            recettes.Add(oeufcocotte);

            Recette tomatemozza = new Recette("tomates mozzarella", new List<Ingredient> { tomate, mozzarella }, 1500, 500, "ENTREE");
            recettes.Add(tomatemozza);

            Recette pommeterresurprise = new Recette("pomme de terre surprise", new List<Ingredient> { pommedeterre, oeuf, poivre, carotte, chou }, 500, 1500, "ENTREE");
            recettes.Add(pommeterresurprise);
        }

        public Recette SearchRecetteByName(string name)
        {
            foreach (Recette recette in recettes)
            {
                if (recette.nomRecette == name)
                {
                    return recette;
                }
            }

            return null;
        }
    }
}
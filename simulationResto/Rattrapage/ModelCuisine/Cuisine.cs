using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rattrapage.ModelCuisine
{
    public class Cuisine
    {
        private static Objets Objets;
        private static Cuisinier Cuisinier;

        private readonly Thread commandeThread;

        readonly List<List<Recette>> commandes = new List<List<Recette>>();
        private static List<Recette> recette = new List<Recette>();
        private static List<int> idTable = new List<int>();
        private static readonly List<string> typeavencement = new List<string> { "ENTREE", "PLAT", "DESSERT", "terminé" };
        
        public Cuisine()
        {
            Cuisinier = new Cuisinier();
            Objets = new Objets();
            Objets.Preparation();

            commandeThread = new Thread(Commande);
            commandeThread.Start();
        }


        public void AddCommande(List<string> commande, int groupeTable)
        {
            foreach (string nomrecette in commande)
            {
                recette.Add(Objets.SearchRecetteByName(nomrecette));
            }   
            
            commandes.Add(recette);
            idTable.Add(groupeTable);
            recette = new List<Recette>();
        }

        public void Commande()
        {
            while (true)
            {
                if (commandes.Count != 0 && idTable.Count != 0)
                {
                    int groupeClient = idTable[0];
                    for (int nbcommande = 0; nbcommande < commandes.Count; nbcommande++)
                    {
                        List<Recette> commande = commandes[nbcommande];
                        int platencours = 0;

                        while (platencours != 3)
                        {
                            foreach (Recette recipe in commande.Where(type => type.typeP == typeavencement[platencours]))
                            {
                                Cuisinier.Cuisiner(recipe);
                                Console.WriteLine("----------------------------- Chef de cuisine : Nous commençons la préparation de la table " + groupeClient +"- " + typeavencement[platencours]);

                                if (platencours != 0)
                                {
                                    Console.WriteLine("----------------------------- Cuisinier : Le " + recipe.typeP + " " + recipe.nomRecette + " de la table " + groupeClient + " est prêt.");
                                }
                                else
                                {
                                    Console.WriteLine("----------------------------- Cuisinier : L' " + recipe.typeP + ": " + recipe.nomRecette + " de la table " + groupeClient + " est prêt.");
                                }

                            }

                            if (platencours != 0)
                            {
                                Console.WriteLine("----------------------------- Tous les " + typeavencement[platencours] + " de la table " + groupeClient + " sont prêts.");
                            }
                            else
                            {
                                Console.WriteLine("----------------------------- Toutes les " + typeavencement[platencours] + " de la table " + groupeClient + " sont prêtes.");
                            }
                            Console.WriteLine("----------------------------- Chef de cuisine : Les assiettes peuvent être ammenées à la table" + groupeClient + " pour dégustation.");
                            Console.WriteLine("Waiter : Table numéro " + groupeClient + " Voici vos " + typeavencement[platencours]);


                            platencours++;
                            Thread.Sleep(1000);

                        }

                        commandes.Remove(commandes[nbcommande]);
                        idTable.Remove(idTable[0]);
                        Console.WriteLine("Les clients de la table " + groupeClient + " ont terminé. Ils se dirigent vers la réception pour aller payer l'addition.");
                        Thread.Sleep(3000);
                    }
                }
            }
        }        
    }
}

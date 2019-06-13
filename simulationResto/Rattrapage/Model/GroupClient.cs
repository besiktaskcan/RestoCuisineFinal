using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Rattrapage.ModelCuisine;

namespace Rattrapage.Model
{
    class GroupClient
    {
        private List<Clients> customers;
        private int nbrClients;

        private string stateGroup;
        private Table tableGroup;

        private Cuisine cuisine = new Cuisine();
        private List<string> commande = new List<string>();

        private Card card;
        public Card Card { get => card; set => card = value; }

        private Thread groupClientsThread;

        public GroupClient()
        {
            customers = new List<Clients>();
            Random rand = new Random();
            nbrClients = rand.Next(2, 8);

            for(int i = 0; i < nbrClients; i++){
                customers.Add(new Clients());
            }
        }

        public void GroupClientThread()
        {

        }


        public void GroupClientChoice(Card card)
        {
            this.card = card;
            Random rand = new Random();
      
            foreach(Clients clients in this.customers)
            {
                int randomVariable = rand.Next(card.Entrees.Count);
                int randomVariable2 = rand.Next(card.Plats.Count);
                int randomVariable3 = rand.Next(card.Deserts.Count);
                clients.choice(this.card, randomVariable, randomVariable2, randomVariable3);
            }
        }

        public void TakeGroupClientChoice()
        {
            foreach (Clients clients2 in this.customers)
            {
                Console.WriteLine("Clients de la table " + this.GroupTable.IdTable + " : entrée - " + clients2.HaveChoice[0] + ", plat - " + clients2.HaveChoice[1] + ", dessert - " + clients2.HaveChoice[2]);
                commande.Add(clients2.HaveChoice[0]);
                commande.Add(clients2.HaveChoice[1]);
                commande.Add(clients2.HaveChoice[2]);
            }
            Console.WriteLine("Chef de rang : La commande de la table " + this.GroupTable.IdTable + " est envoyé en cuisine.");
            //Cuisine cuisine = new Cuisine(commande, this.GroupTable.IdTable);
            cuisine.AddCommande(commande, this.GroupTable.IdTable);
            //this.tableGroup.Occupied = false;
        }

        public void AddClients(Clients clients)
        {
            this.customers.Add(clients);
        }

        public List<Clients> clients { get => customers; }
        public Table GroupTable { get => tableGroup; set => tableGroup = value; }
        public int NbrClients { get => nbrClients; }        
    }
}

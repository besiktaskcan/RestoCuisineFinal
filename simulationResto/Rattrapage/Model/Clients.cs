using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Clients
    {
        private string nameClient;
        private int idClient;
        private List<string> order;
        private string[] haveChoice;
        public string[] HaveChoice { get => haveChoice; }
        private Table table;

        public Clients()
        {
            
        }

        public void choice(Card card, int rand, int rand2, int rand3)
        {
            //Random rand = new Random();
            //Console.WriteLine(rand);
            haveChoice = new string[3] {card.Entrees[rand], card.Plats[rand2], card.Deserts[rand3]};
        } 
    }
}

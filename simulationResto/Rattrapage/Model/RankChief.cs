using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rattrapage.Model
{
    class RankChief : Employes
    {
        private Thread rankChiefThread;
        private Square square;

        private List<GroupClient> groupClients;


        public RankChief(Room room, Square square) : base(room)
        {
            this.square = square;
            groupClients = new List<GroupClient>();
            rankChiefThread = new Thread(new ThreadStart(this.CallRankChiefThread));
            rankChiefThread.Start();
        }

        public void CallRankChiefThread()
        {
            Console.WriteLine("Le chef de rang est là.");

        }

        public void PlacerGroupe(GroupClient groupclient, int idTable)
        {

            this.square.Tables.Find(x => x.IdTable == idTable).Clients = groupclient;
            groupclient.GroupTable = this.square.Tables.Find(x => x.IdTable == idTable);
            Console.WriteLine("Chef de rang : Installez-vous à la table " + groupclient.GroupTable.IdTable + " s'il vous plaît");
            Thread.Sleep(500);
            Console.WriteLine("Chef de rang : Voici le menu");
            Thread.Sleep(1000);
            Console.WriteLine("Clients de la table " + groupclient.GroupTable.IdTable + " : Nous réflechissons");
            Thread.Sleep(2000);
            groupclient.GroupClientChoice(new Card());
            Thread.Sleep(3000);
            groupclient.TakeGroupClientChoice();
            Thread.Sleep(3000);
        }
    }
}

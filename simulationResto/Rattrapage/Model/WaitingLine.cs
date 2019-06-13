using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rattrapage.Model
{
    class WaitingLine
    {
        private List<GroupClient> clients;
        

        public WaitingLine()
        {
            clients = new List<GroupClient>();

        }

        public void AjouterClientsWaitline(GroupClient groupe)
        {
            clients.Add(groupe);
            Console.WriteLine("Un groupe de client arrive. Le groupe de client est ajouté à la liste");
        }

        public List<GroupClient> Clients { get => clients;  }
    }
}

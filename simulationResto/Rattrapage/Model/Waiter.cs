using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rattrapage.Model
{
    class Waiter
    {
        private List<GroupClient> groupClient;
        private Thread waiterThread;

        public Waiter()
        {
            GroupClient = new List<GroupClient>();
            waiterThread = new Thread(WaiterThread);
            waiterThread.Start();
        }

        public void WaiterThread()
        {
            Console.WriteLine("Les serveurs sont en place.");
            //Wait();

        }

        public void Wait()
        {
            Console.WriteLine("Waiter : J'attends");
            Thread.Sleep(2000);
        }

        public void Debarrasser()
        {
            Console.WriteLine("Waiter: débarasse la table");
        }

        public List<GroupClient> GroupClient { get => groupClient; set => groupClient = value; }
    }
}

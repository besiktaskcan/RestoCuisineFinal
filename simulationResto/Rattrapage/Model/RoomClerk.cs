using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rattrapage.Model
{
    class RoomClerk
    {
        private Thread roomClerkThread;

        private Stock stockRoom;
        public RoomClerk(Stock stockRoom)
        {
            this.stockRoom = stockRoom;
        }

        public void CallRoomClerk(Table table)
        {
            this.stockRoom.BottleNbr = this.stockRoom.BottleNbr - 1;
            this.stockRoom.BreadNbr = this.stockRoom.BreadNbr - 1;
            table.Bread = table.Bread + 1;
            table.Bottle = table.Bottle + 1;
            Console.WriteLine("Commis de salle : Voici du pain et de l'eau.");
            Thread.Sleep(500);
        }
    }
}

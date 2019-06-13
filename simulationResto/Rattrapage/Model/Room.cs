using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rattrapage.Model
{
    class Room
    {
        //carre
        private Square square1;
        private Square square2;
        public Square Square1 { get => square1; set => square1 = value; }
        public Square Square2 { get => square2; set => square2 = value; }

        //different postes de travail
        private HeadWaiter headWaiter;
        public HeadWaiter HeadWaiter { get => headWaiter; set => headWaiter = value; }

        private RankChief rankChief;
        public RankChief RankChief { get => rankChief; set => rankChief = value; }

        private RankChief rankChief2;
        public RankChief RankChief2 { get => rankChief2; set => rankChief2 = value; }

        private RoomClerk roomClerk;
        public RoomClerk RoomClerk { get => roomClerk; set => roomClerk = value; }



        private WaitingLine waitingLine;

        private GroupClient clients;
        private Order order;
        private Card card;
        private Stock stockRoom;

        //private static List<Table> table1;
        //private static List<Table> table2;
        private static Room instance;
        private static readonly object padlock = new object();

        public Room()
        {
            Console.WriteLine("Ouverture du restaurant!");
            Thread.Sleep(3000);
            waitingLine = new WaitingLine();

            square1 = new Square();
            square2 = new Square();

            stockRoom = new Stock(40,40);
            roomClerk = new RoomClerk(stockRoom);

            headWaiter = new HeadWaiter(this);
            rankChief = new RankChief(this, square1);
            rankChief2 = new RankChief(this, square2);

            clients = new GroupClient();

        }

        public static Room Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Room();
                        }
                    }
                }
                return instance;
            }
        }

      



    }
}

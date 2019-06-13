using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Table
    {

        private int idTable;
        public int IdTable { get => idTable; set => idTable = value; }


        private static int idIncrementor = 0;

        private int numberPlace;
        public int NumberPlace { get => numberPlace; set => numberPlace = value; }


        private bool occupied;
        public bool Occupied { get => occupied; set => occupied = value; }

        private GroupClient clients;
        public GroupClient Clients { get => clients; set => clients = value; }

        private int bread;
        private int bottle;
        public int Bread { get => bread; set => bread = value; }
        public int Bottle { get => bottle; set => bottle = value; }

        public Table(int number)
        {
            IdTable = idIncrementor;
            idIncrementor++;

            numberPlace = number;
            occupied = false;

            Bread = 0;
            bottle = 0;
        }
    }
}

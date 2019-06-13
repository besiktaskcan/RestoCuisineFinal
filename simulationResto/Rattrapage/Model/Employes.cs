using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rattrapage.Model
{
    abstract class Employes
    {
        public Room room;

        public Employes(Room room)
        {
            this.room = room;
        }


    }
}
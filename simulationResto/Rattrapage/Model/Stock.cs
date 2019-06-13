using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Stock
    {
        private int bottleNbr;
        private int breadNbr;
        public int BottleNbr { get => bottleNbr; set => bottleNbr = value; }
        public int BreadNbr { get => breadNbr; set => breadNbr = value; }
        public Stock(int bottle, int bread)
        {
            BottleNbr = bottle;
            BreadNbr = bread;
        }
    }
}

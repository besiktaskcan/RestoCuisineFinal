using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Square
    {

        private List<Table> tables;
        private List<Waiter> waiters;

        public Square()
        {


            Table table1 = new Table(4);
            Table table2 = new Table(4);
            Table table3 = new Table(4);
            Table table4 = new Table(4);
            Table table5 = new Table(4);
            Table table6 = new Table(4);
            Table table7 = new Table(8);
            Table table8 = new Table(8);
            Table table9 = new Table(8);
            Table table10 = new Table(8);
            Table table11 = new Table(8);

            tables = new List<Table>();

            tables.Add(table1);
            tables.Add(table2);
            tables.Add(table3);
            tables.Add(table4);
            tables.Add(table5);
            tables.Add(table6);
            tables.Add(table7);
            tables.Add(table8);
            tables.Add(table9);
            tables.Add(table10);
            tables.Add(table11);

            Waiters = new List<Waiter>();

            Waiters.Add(new Waiter());
            Waiters.Add(new Waiter());
        }

        public List<Table> Tables { get => tables; }
        public List<Waiter> Waiters { get => waiters; set => waiters = value; }
    }
}

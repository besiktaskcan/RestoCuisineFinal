using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Card
    {
        private static readonly List<string> entrees = new List<string> { "oeufs à la coque", "oeuf cocotte", "tomates mozzarella", "pomme de terre surprise" };
        private static readonly List<string> plats = new List<string> { "spaghetti bolognaise", "nuggets et frites", "fish and chips", "riz au poulet" };
        private static readonly List<string> desserts = new List<string> { "crêpe au chocolat", "glace au chocolat", "tiramisu", "gateau à la vanille", "tarte aux pommes" };

        public  List<string> Entrees { get => entrees; }
        public  List<string> Plats { get => plats;  }
        public  List<string> Deserts { get => desserts; }


    }
}

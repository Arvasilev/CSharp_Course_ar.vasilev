using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Card
    {
        private string name;
        private long synCode;
        private long id;

        public Card()
        {
            name = "Ivan";
            synCode = 100500;
            id = 1;
        }
        
        public Card(string name, long synCode, long id)
        {
            this.name = name;
            this.synCode = synCode;
            this.id = id;
        }

        static void Main(string[] args)
        {
            Card changeNameAndID = new Card("alena", 100500, 50);


        }
    }
}

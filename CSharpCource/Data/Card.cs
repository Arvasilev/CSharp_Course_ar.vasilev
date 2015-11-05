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

        public void SetName (string name)
        {
             this.name = name;
        }

        public void SetId(long id)
        {
             this.id = id;
        }


    }
}

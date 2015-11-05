namespace Data
{
    class Contacts
    {
        public string Name { get; private set; }

        public Contacts(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Имя: {0}\n", Name);
        }
    }
}

namespace Data
{
    class Contact
    {
        public string Name { get; private set; }

        public Contact(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Имя: {0}\n", Name);
        }
    }
}

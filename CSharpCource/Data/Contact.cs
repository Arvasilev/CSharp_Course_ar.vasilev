namespace Data
{
    using System;
    using System.Xml.Linq;

    public class Contact : IComparable, ICloneable
    {
        public string Name { get; set; }

        protected Contact(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("Имя: {0}\n", this.Name);
        }

        /// <summary>
        /// (Лекция 5.2) The clone.
        /// </summary>
        public object Clone()
        {
            return new Contact(Name);
        }

        /// <summary>
        /// (Лекция 5.2) The compare.
        /// </summary>
        public int CompareTo(object objectContact)
        {
            if (objectContact == null)
            {
                return 1;
            }

            var otherContact = objectContact as Contact;
            if (otherContact != null)
            {
                return (string.Compare(this.Name, otherContact.Name, System.StringComparison.Ordinal));
            }
            else
            {
                throw new ArgumentException("В списке ктонактов нет такого объекта");
            }
        }

        public virtual XElement ToXml()
        {
            var contact = new XElement("Contact", new XAttribute("Name", Name));
            return contact;
        }
    }
}
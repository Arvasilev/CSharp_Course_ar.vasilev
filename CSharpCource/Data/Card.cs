namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class Card : IComparable, ICloneable
    {
        private string Name { get;  set; }

        private long SynCode { get; set; }

        private long Id { get; set; }

        public List<Contact> ContactsList { get; set; }

        /// <summary>
        /// Создание карточки с фиксированными параметрами.
        /// </summary>
        public Card()
        {
            this.Name = "Ivan";
            this.SynCode = 100500;
            this.Id = 1;
            this.ContactsList = new List<Contact>();
        }

        /// <summary>
        /// Создание карточки с указаными параметрами.
        /// </summary>
        public Card(string name, long synCode, long id)
        {
            this.Name = name;
            if (string.IsNullOrWhiteSpace(name))
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentNullException("Имя карточки не может быть пустым.");
                }
            }

            this.SynCode = synCode;
            if (synCode == 0)
            {
                throw new FormatException("У карточки должен быть SynCode.");
            }

            this.Id = id;
            if (id < 0)
            {
                throw new FormatException("Id не может быть отрицательным.");
            }
            this.ContactsList = new List<Contact>();
        }

        /// <summary>
        /// Устанавливает значение name.
        /// </summary>
        public void SetName (string name)
        {
            this.Name = name;
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя карточки не может быть пустым.");
            }
        }

        /// <summary>
        /// Устанавливает значение id.
        /// </summary>
        public void SetId(long id)
        {
             this.Id = id;
            if (id < 0)
            {
                throw new FormatException("Id не может быть отрицательным.");
            }
        }
        public long GetId
        {
            get { return Id; }
        }
        /// <summary>
        /// Устанавливает значение synCode.
        /// </summary>
        public void SetSynCode(long synCode)
        {
            this.SynCode = synCode;
            if (synCode == 0)
            {
                throw new FormatException("У карточки должен быть SynCode.");
            }
        }
        /// <summary>
        /// Добавляет контакт в список
        /// </summary>
        public void AddContact(Contact contact)
        {
            this.ContactsList.Add(contact);
        }

        /// <summary>
        /// Удаляет из списка контакт с указаным именем.
        /// </summary>
        public bool DelContact(String name)
        {
            int i = ContactsList.FindIndex(x => x.Name == name);
            if (i == -1)
                return false;

            ContactsList.RemoveAt(i);
            return true;
        }
        /// <summary>
        /// Выводит список контактов
        /// </summary>
        public string Print()
        {
            return ContactsList.Aggregate("", (current, cont) => current + (cont.ToString() + "\n"));
        }

        /// <summary>
        /// (Лекция 5.2) Сравнивает две карточки.
        /// </summary>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherCard = obj as Card;
            if (otherCard != null)
            {
                if (this.Id != otherCard.Id)
                    return this.Id.CompareTo(otherCard.Id);
                if (!this.Name.Equals(otherCard.Name))
                    return this.Name.CompareTo(otherCard.Name);
                return this.SynCode.CompareTo(otherCard.SynCode);
            }
            else
                throw new ArgumentException("В списке карточек нет такого объекта");
        }

        /// <summary>
        /// (Лекция 5.2) Клонирует две карточки. 
        /// </summary>
        public object Clone()
        {
            var newCard = new Card();
            newCard.Name = (string)this.Name.Clone();
            newCard.Id = this.Id;
            newCard.SynCode = this.SynCode;
            foreach (var contact in ContactsList)
            {
                newCard.ContactsList.Add((Contact)contact.Clone());
            }
            return newCard;
        }

        public XElement ToXml()
        {
            var card = new XElement("Card", new XAttribute("Id", Id), new XAttribute("Name", Name), new XAttribute("SynCode", SynCode));
            var contacts = new XElement("Contacts");
            card.Add(contacts);

            foreach (var contact in ContactsList)
            {
                contacts.Add(contact.ToXml());
            }
            return card;

        }
    }
}

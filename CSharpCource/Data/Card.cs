namespace Data
{
    using System;
    using System.Collections.Generic;

    public class Card : IComparable, ICloneable
    {
        private string Name { get;  set; }

        private long SynCode { get; set; }

        private long Id { get; set; }

        private List<Contact> ContactsList { get; set; }

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
        /// Выводит список контактов
        /// </summary>
        public void Print()
        {
            foreach (var cont in this.ContactsList)
            {
                Console.WriteLine(cont.ToString());
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Удаляет из списка контакт с указаным именем.
        /// </summary>
        public void DelContact(string name)
        {
            int i = 0;
            foreach (var contact in this.ContactsList)
            {
                if (contact.Name == name)
                {
                    break;
                }

                i++;

                if (i == -1)
                {
                    Console.WriteLine("Такого контакта нет в списке");
                    return;
                }

                this.ContactsList.RemoveAt(i);
            }
        }

        /// <summary>
        /// (Лекция 5.2) Сравнивает две карточки.
        /// </summary>
        public int CompareTo(object objectCard)
        {
            if (objectCard == null)
            {
                return 1;
            }

            var otherCard = objectCard as Card;
            if (otherCard == null)
            {
                throw new ArgumentException("В списке карточек нет такого объекта");
            }

            if (this.Id != otherCard.Id)
            {
                return this.Id.CompareTo(otherCard.Id);
            }

            return !this.Name.Equals(otherCard.Name) ? string.Compare(this.Name, otherCard.Name, StringComparison.Ordinal) : this.SynCode.CompareTo(otherCard.SynCode);
        }

        /// <summary>
        /// (Лекция 5.2) Клонирует две карточки. 
        /// </summary>
        public object Clone()
        {
            var newCard = new Card { Name = (string)this.Name.Clone(), Id = this.Id, SynCode = this.SynCode };
            foreach (var contact in this.ContactsList)
            {
                newCard.ContactsList.Add((Contact)contact.Clone());
            }

            return newCard;
        }
    }
}

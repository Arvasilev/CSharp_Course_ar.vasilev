using System;
using System.Collections.Generic;
using ContactsCard;

namespace Data
{
    class Card
    {
        private string _name;
        private long synCode;
        private long id;

        public Card()
        {
            _name = "Ivan";
            synCode = 100500;
            id = 1;
            _contactsList = new List<Contact>();
        }
        
        public Card(string name, long synCode, long id)
        {
            this._name = name;
            this.synCode = synCode;
            this.id = id;
        }

        public void SetName (string name)
        {
             this._name = name;
        }

        public void SetId(long id)
        {
             this.id = id;
        }

        private static List<Contact> _contactsList;


        
        public static void AddContact()
        {
            Contact contact = null;
            string name;
            Console.WriteLine("Выберите тип контакта:\n1 - Телефон\n2 - Email");
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Введите имя");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите код города");
                        string telCode = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона");
                        string telephone = Console.ReadLine();
                        contact = new PhoneContact(name, telCode + "." + telephone);
                        break;

                    case 2:
                        Console.WriteLine("Введите имя");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите E-mail");
                        string email = Console.ReadLine();
                        contact = new EmailContact(name, email);
                        break;

                    default:
                        Console.WriteLine("Такой команды нет в списке");
                        return;
                }
                _contactsList.Add(contact);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели некорректный запрос, введите число от 1 до 2");
            }
        }

        public static void Print()
        {
            foreach (var cont in _contactsList)
            {
                Console.WriteLine(cont.ToString());
            }
            Console.WriteLine();
        }

        public static void DelContact(String name)
        {
            int i = 0;
            foreach (Contact contact in _contactsList)
            {
                if (contact.Name == name)
                    break;
                i++;

                if (i == -1)
                {
                    Console.WriteLine("Такого контакта нет в списке");
                    return;
                }
                _contactsList.RemoveAt(i);
            }
        }

        public void RunLecture42()
        {
            Card card = new Card();
            while (true)
            {
                Console.WriteLine(
                    "Выберите действие:\n1 - Добавление контакта  карточку\n2 - Вывод списка контактов на экран\n3 - Удаление выбранного контакта\n4 - Выход");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            AddContact();
                            break;
                        case 2:
                            Print();
                            break;
                        case 3:
                            Console.WriteLine("Введите имя контакта для удаления");
                            DelContact(Console.ReadLine());
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Введена некорретная комманда");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректный запрос, введите число от 1 до 4");
                    Console.ReadKey();
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using ContactsCard;

namespace Data
{
    internal class Program
    {
        private static List<Contacts> _contactsList;

        public Program()
        {
            _contactsList = new List<Contacts>();

        }

        public static void AddContact()
        {
            Contacts contact = null;
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
                        contact = new TelContacts(name, telCode + "." + telephone);
                        break;

                    case 2:
                        Console.WriteLine("Введите имя");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите alias");
                        string alias = Console.ReadLine();
                        Console.WriteLine("Введите E-mail");
                        string email = Console.ReadLine();
                        contact = new EmailContacts(name, email + " ("+ alias +")");
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
            foreach (Contacts contact in _contactsList)
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
            string name;
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
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели некорректный запрос, введите число от 1 до 4");
                    Console.ReadKey();
                }
            }


        }
    }
}

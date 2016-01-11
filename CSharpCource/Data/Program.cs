namespace Data
{
    using System;

    using ContactsCard;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод запуска консольного приложения
        /// </summary>
        public void RunCardApp()
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
                            ConsoleAddContact();
                            break;
                        case 2:
                            var p = new Card();
                            p.Print();
                            break;
                        case 3:
                            Console.WriteLine("Введите имя контакта для удаления");
                            var d = new Card();
                            d.DelContact(Console.ReadLine());
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

        /// <summary>
        /// Консольный метод добавления контактов в список
        /// </summary>
        private static void ConsoleAddContact()
        {
            Console.WriteLine("Выберите тип контакта:\n1 - Телефон\n2 - Email");
            try
            {
                Contact contact;
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Введите имя");
                        var name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            throw new ArgumentNullException("Имя не может быть " + "пустым.");
                        }

                        Console.WriteLine("Введите код города");
                        string telCode = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(telCode))
                        {
                            throw new ArgumentNullException("Код города не может быть" + " пустым.");
                        }

                        Console.WriteLine("Введите номер телефона");
                        string telephone = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(telephone))
                        {
                            throw new ArgumentNullException("Телефон не мо" + "жет быть пустым.");
                        }

                        contact = new PhoneContact(name, telCode + "." + telephone);
                        break;

                    case 2:
                        Console.WriteLine("Введите имя");
                        name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            throw new ArgumentNullException("Имя не может" + " быть пустым.");
                        }

                        Console.WriteLine("Введите E-mail");
                        string email = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(email))
                        {
                            throw new ArgumentNullException("E-mail не может быть" + " пустым.");
                        }

                        contact = new EmailContact(name, email);
                        break;

                    default:
                        Console.WriteLine("Такой команды нет в списке");
                        return;
                }

                var a = new Card();
                a.AddContact(contact);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели некорректный запрос, введите число от 1 до 2");
            }
        }

        /// <summary>
        /// (Лекция 6.1) 
        /// - Создать 3 контакта разного типа, сохранить их в списке. Список контактов сохранить в файл “contacts.txt” любым способом.
        /// - Считать данные из файла “contacts.txt” и вывести на консоль)
        /// </summary>
        public void Lecture6_1()
        {
            var card = new Card();
            var contact1 = new PhoneContact("Ivan", "383" + "." + "3963222");
            card.AddContact(contact1);
            var contact2 = new PhoneContact("Mary", "913" + "." + "1233211");
            card.AddContact(contact2);
            var contact3 = new EmailContact("Ars", "ar.vasilev@2gis.ru");
            card.AddContact(contact3);
        }

    }
}
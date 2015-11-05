using System;

namespace CSharpCource
{
    class lecture_2_1
    {
        static string inputСharacter;
        static int summary;


        public lecture_2_1()
        {
            Console.WriteLine("Вычислитель суммы N-го количества чисел.");
            Console.WriteLine("1. Введите необходимое количество чисел");
            Console.WriteLine("2. Для получения суммы, по завершении ввода, введите любой символ, который не является числом. ");

            while (true) 
            {
                inputСharacter = Console.ReadLine();
                int number;
                bool isNumber = int.TryParse(inputСharacter, out number); // проверяем введенный символ - число или нет
                if (isNumber) 
                {
                    Summaryty(); // если число то суммируем
                }
                else
                    break;
            }
            Console.WriteLine(summary); // если не число выводим сумму
            Console.ReadKey();
        }

        private void Summaryty()
        {
            int numberOne = Convert.ToInt32(inputСharacter);
            summary += numberOne;
        }

    }

}
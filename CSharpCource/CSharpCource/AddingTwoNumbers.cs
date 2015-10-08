using System;

namespace CSharpCource
{
    class AddingTwoNumbers
    {
        public AddingTwoNumbers()
        {
            Console.WriteLine("Вычислитель суммы из двух чисел");
            Console.WriteLine("Введите первое число");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            int Sum = NumberOne + NumberTwo;
            Console.WriteLine("Сумма:" + " " + Sum);
            Console.ReadKey();
        }
    }
}


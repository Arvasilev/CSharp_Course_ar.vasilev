using System;

namespace CSharpCource
{
    class AddingTwoNumbers
    {
        static void Main()
        {
            Console.WriteLine("Вычислитель суммы из двух чисел");
            Console.WriteLine("Введите первое число");
            int DigitOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int DigitTwo = Convert.ToInt32(Console.ReadLine());
            int Sum = DigitOne + DigitTwo;
            Console.WriteLine("Сумма:" + " " + Sum);
            Console.ReadKey();
        }
    }
}

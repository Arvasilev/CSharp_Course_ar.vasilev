using System;

namespace CSharpCource
{
    class AddingTwoNumbers
    {
        static void Main()
        {
            Console.WriteLine("����������� ����� �� ���� �����");
            Console.WriteLine("������� ������ �����");
            int DigitOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ������ �����");
            int DigitTwo = Convert.ToInt32(Console.ReadLine());
            int Sum = DigitOne + DigitTwo;
            Console.WriteLine("�����:" + " " + Sum);
            Console.ReadKey();
        }
    }
}

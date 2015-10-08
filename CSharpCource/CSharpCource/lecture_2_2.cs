using System;
using System.Threading;

namespace CSharpCource
{
    class lecture_2_2
    {
        public lecture_2_2()
        {
            Console.WriteLine("Вычислитель суммы при сложении 2-х матриц");
            Console.WriteLine("Введите размерность матриц");
            Console.WriteLine("Введите число строк");
            int matrix_number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            int matrix_number2 = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[matrix_number1, matrix_number2]; // создаем 1-ю матрицу и заполняем ее числами до 100
            for (int i = 0; i < matrix_number1; i++)
            {
                for (int j = 0; j < matrix_number2; j++)
                {
                    Random rnd = new Random();
                    matrix1[i, j] = rnd.Next(0, 100);
                    Thread.Sleep(20); // добавляем задержку, что бы числа были действительно рандомными
                }
            }

            int[,] matrix2 = new int[matrix_number1, matrix_number2]; // создаем 2-ю матрицу и заполняем ее числами до 100
            for (int i = 0; i < matrix_number1; i++)
            {
                for (int j = 0; j < matrix_number2; j++)
                {
                    Random rnd = new Random();
                    matrix2[i, j] = rnd.Next(0, 100);
                    Thread.Sleep(20); // добавляем задержку, что бы числа были действительно рандомными
                }
            }

            int[,] result = new int[matrix_number1, matrix_number2]; // складываем значния матриц

            for (int i = 0; i < matrix_number1; i++)
            {
                for (int j = 0; j < matrix_number2; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];

                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

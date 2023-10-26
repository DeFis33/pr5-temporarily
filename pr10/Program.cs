//***************************************************************
//* Практическая работа № 10                                    *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: обработать двухмерный массив                       *
//***************************************************************

using System;
using System.Net;

namespace pr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №10.\nЗдравствуйте!\n");

            while (true)
            {
                try
                {
                    int M = 3, N = 5;
                    Random rnd = new Random(); // создание экземпляра генератора случайных чисел
                    int[,] matrix = new int[M, N]; // объявление и инициализация двумерного массива
                    int product = 1; // product - хранение произведения ненулевых элементов матрицы

                    Console.WriteLine("Хотите ли вы сами ввести элементы матрицы? (Да/Нет).\nЛибо введите команду (Выход), которая завершит работу программы:");
                    string a = Console.ReadLine();
                    Console.WriteLine("");

                    if (a == "Выход")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    if (a == "Да") // если пользователь хочет сам ввести элементы матрицы, то
                    {
                        Console.WriteLine("Введите элементы матрицы:");
                        for (int i = 0; i < M; i++) // ввод по строкам
                        {
                            for (int j = 0; j < N; j++) // ввод по столбцам
                            {
                                Console.Write("Элемент [" + i + ", " + j + "]: ");
                                matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                                if (matrix[i, j] != 0) // если matrix[i, j] не равно нулю, то
                                {
                                    product *= matrix[i, j]; // умножение текущего значения product на значение ненулевого элемента, накапливая произведение ненулевых элементов
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (a == "Нет") // иначе
                    {
                        for (int i = 0; i < M; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                matrix[i, j] = rnd.Next(-100, 101); // генерация неповторяющихся значений
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(matrix[i, j] + "\t");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (matrix[i, j] != 0)
                                {
                                    product *= matrix[i, j];
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет!");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nПроизведение ненулевых элементов: " + product);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ReadKey();
        }
    }
}

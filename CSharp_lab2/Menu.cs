/*
Лабораторная работа №2

Студент группы 17ИС1

Михаил Никитин Сергеевич

Вариант 1: Разработать динамически подключаемую библиотеку dll, содержащая среднеарифметическое и среднегеометрическое значение одномерных и двумерных массивов.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMassive;

namespace CSharp_lab2
{
    class Menu
    {
        static void Main(string[] args)
        {
            int number, number_1 = 0;
            int x, y;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Одномерный массив: ");
            Console.WriteLine("2. Двумерный массив: ");
            Console.WriteLine("3. Выход из Программы");
            Console.Write("Выберите пункт 1 - 3: ");
            number = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(number)
            {
                case 1:
                    
                        Console.WriteLine("Введите размерность массива [x] :");
                        x = int.Parse(Console.ReadLine());
                        MassiveInfo masive_1 = new MassiveInfo(x, 0, number);
                        masive_1.InPut();
                        Console.Clear();
                    do {
                        Console.Clear();
                        Console.WriteLine("1. Среднеарефметическое x");
                        Console.WriteLine("2. Среднегеометрическое y");
                        Console.WriteLine("3. Выход из Программы");
                        Console.Write("Выберите пункт 1 - 3: ");
                        number_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (number_1 == 1)
                        {
                            masive_1.Show();
                            masive_1.ArithmeticMean();
                            Console.WriteLine("Нажмите любую кнопку чтобы вернуться");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        if (number_1 == 2)
                        {
                            masive_1.Show();
                            masive_1.GeometricMean();
                            Console.WriteLine("Нажмите любую кнопку чтобы вернуться");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while (number_1 != 3);
                    break;
                case 2:
                    Console.WriteLine("Введите размерность массива [x][y] :");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    MassiveInfo masive_2 = new MassiveInfo(x, y, number);
                    masive_2.InPut();
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("1. Среднеарефметическое x");
                        Console.WriteLine("2. Среднегеометрическое y");
                        Console.WriteLine("3. Выход из Программы");
                        Console.Write("Выберите пункт 1 - 3: ");
                        number_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (number_1 == 1)
                        {
                            masive_2.Show();
                            masive_2.ArithmeticMean();
                            Console.WriteLine("Нажмите любую кнопку чтобы вернуться");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        if (number_1 == 2)
                        {
                            masive_2.Show();
                            masive_2.GeometricMean();
                            Console.WriteLine("Нажмите любую кнопку чтобы вернуться");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while (number_1 != 3);
                    break;
                case 3:
                    Console.ReadKey();
                    break;
                default:
                    if (number > 3 | number < 1)
                        Console.WriteLine("Ошибка, повторите попытку");
                    break;
            }
        }

        
    }
}

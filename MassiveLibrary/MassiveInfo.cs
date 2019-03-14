using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMassive
{
    public class MassiveInfo
    {
        int number;
        private int x, y;
        private int[] massive_1;
        private int[,] massive_2;

        public MassiveInfo(int x, int y, int number)
        {
            this.number = number;
            this.x = x;
            this.y = y;
            if (number == 1)
                massive_1 = new int[x];
            if (number == 2)
                massive_2 = new int[x, y];
        }

        // Показать значения массива
        public void Show()
        {
            Console.Write("Массив : \n");
            if (number == 1)
            {
                for (int i = 0; i < x; i++)
                    Console.Write(string.Format("{0,3}", massive_1[i]));
            }
            if (number == 2)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                        Console.Write(string.Format("{0,3}", massive_2[i, j]));
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        // Ввод значений в массив
        public void InPut()
        {
            if (number == 1)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("Элемент [" + i + "] = ");
                    massive_1[i] = int.Parse(Console.ReadLine());
                }
            }
            if (number == 2)
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("Элемент [" + i + "]" + "[" + j + "] = ");
                        massive_2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
        }
        // Посчитать среднеарефметическое
        public void ArithmeticMean()
        {
            int sum = 0;
            if (number == 1)
            {
                for (int i = 0; i < x; i++)
                    sum += massive_1[i];
                Console.WriteLine("Среднеарефметическое равно = " + (sum / massive_1.Length));

            }
            if (number == 2)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                        sum += massive_2[i, j];
                }
                Console.WriteLine("Среднеарефметическое равно = " + (sum / massive_2.Length));
            }


        }

        // Посчитать среднегеометрическое
        public void GeometricMean()
        {
            double geometric = 0;
            int sum = 1;
            if (number == 1)
            {
                for (int i = 0; i < x; i++)
                    sum *= massive_1[i];
                geometric = Math.Pow(sum, 1.0 / massive_1.Length);
                Console.WriteLine("Среднегеометрическое равно = " + geometric);
            }
            if (number == 2)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                        sum *= massive_2[i, j];
                }
                geometric = Math.Pow(sum, 1.0 / massive_2.Length);
                Console.WriteLine("Среднегеометрическое равно = " + geometric);
            }
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Practice__6
{
    class Program
    {
        static void Main(string[] args) // Точка входа в приложение 
        {
            Input();
        }

        static void Input() // Функция работы ввода 
        {
            Console.Clear();
            Console.WriteLine("Учебная практика №6, Власов Виктор");
            Console.WriteLine("Вариант: 10");
            Console.WriteLine("Ввести а1, а2, а3, N. Построить последовательность чисел а(к) = 13 * а(к–1) – 10 * а(к-2) + а(к–3)");
            Console.WriteLine("Построить N элементов последовательности проверить, образуют ли элементы, стоящие на четных местах, возрастающую подпоследовательность.");
            while (1 > 0)
            {
                Console.WriteLine();
                double a1, a2, a3;
                int N;
                bool ok = false;
                do // Проверка ввода
                {
                    Console.Write("Введите число a1: ");
                    ok = Double.TryParse(Console.ReadLine(), out a1);
                    if (!ok) { Console.WriteLine("Введите действительное число!"); ok = false; }
                }
                while (!ok);
                ok = false;
                do // Проверка ввода
                {
                    Console.Write("Введите число a2: ");
                    ok = Double.TryParse(Console.ReadLine(), out a2);
                    if (!ok) { Console.WriteLine("Введите действительное число!"); ok = false; }
                }
                while (!ok);
                ok = false;
                do // Проверка ввода
                {
                    Console.Write("Введите число a3: ");
                    ok = Double.TryParse(Console.ReadLine(), out a3);
                    if (!ok) { Console.WriteLine("Введите действительное число!"); ok = false; }
                }
                while (!ok);
                ok = false;
                do // Проверка ввода
                {
                    Console.Write("Введите число N: ");
                    ok = Int32.TryParse(Console.ReadLine(), out N);
                    if (!ok || N < 4) { Console.WriteLine("Введите натуральное число больше 3!"); ok = false; }
                }
                while (!ok);
                Sequence(a1, a2, a3, N);
            }
        }

        static void Sequence(double a1, double a2, double a3, int N) // Построение последовательности
        {
            bool Increases = true;
            double[] Values = new double[N];
            Values[0] = a1;
            Console.WriteLine("a{0}: {1}", 1, Values[0]);
            Values[1] = a2;
            Console.WriteLine("a{0}: {1}", 2, Values[1]);
            Values[2] = a3;
            Console.WriteLine("a{0}: {1}", 3, Values[2]);
            for (int i = 3; i < N; i++)
            {
                Values[i] = 13 * Values[i - 1] - 10 * Values[i - 2] + Values[i - 3];
                Console.WriteLine("a{0}: {1}", i+1, Values[i]);
                if (i % 2 == 0 && Increases == true)
                {
                    if(Values[i] <= Values[i - 2]) { Increases = false; }
                }
            }
            if (Increases)
            {
                Console.WriteLine("Элементы на четных местах образуют возрастающую последовательность");
            }
            else
            {
                Console.WriteLine("Элементы на четных местах не образуют возрастающую последовательность");
            }
        }
    }
}

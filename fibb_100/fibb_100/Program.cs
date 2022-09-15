using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibb_100
{
    class Program
    {
        static int InputInt(string message, int min, int max)
        {
            int number;
            bool isRead = false;
            bool isValid = false;
            do
            {
                Console.WriteLine(message);
                isRead = int.TryParse(Console.ReadLine(), out number);
                if (!isRead)
                {
                    Console.WriteLine("Ошибка при вводе целого числа");
                }
                else
                {
                    if (number < min || number > max)
                    {
                        Console.WriteLine($"Число должно быть больше {min}  и меньше {max} ");
                        isValid = false;
                    }
                    else
                        isValid = true;

                }
            } while (!isRead || !isValid);
            return number;
        }

        //static ulong Fibb(int n)
        //{
        //    ulong a = 0;
        //    ulong b = 1;
        //    for (int i = 2; i <= n; ++i)
        //    {
        //        ulong next = a + b;
        //        a = b;
        //        b = next;
        //    }

        //    return b;
        //}

        ////private static decimal Fibonacci(int n)
        ////{
        ////    if (n == 0)
        ////        return 0;
        ////    decimal fib_n_2 = 0, fib_n_1 = 1;
        ////    for (int i = 1; i < n; i++)
        ////    {
        ////        var temp = fib_n_1;
        ////        fib_n_1 += fib_n_2;
        ////        fib_n_2 = temp;
        ////    }
        ////    return fib_n_1;
        ////}

        static decimal Fibb(int n)
        {
            decimal cache1 = 0;
            decimal cache2 = 1;
            decimal cache3;
            for (int i = 2; i <= n; i++)
            {
                cache3 = cache1 + cache2;
                cache1 = cache2;
                cache2 = cache3;
            }
            return cache2;
        }
        static void Main(string[] args)
        {
            int answer = InputInt("Введите номер искомого числа", 0, 100);
            for(int i =  1; i<=answer;i++)
            {
                Console.WriteLine($"Номер {i} последовательности равен {Fibb(i)}");
                //if(i<=47)
                //    Console.WriteLine($"Номер {i} последовательности равен {Fibb(i)}");
                //else
                //{
                //    Console.WriteLine($"Остаток от делания на 100000 элемента {i} последовательности равен {Fibb(i)%10000}");
                //}
            }
        }
    }
}

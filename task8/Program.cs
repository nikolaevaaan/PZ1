// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);
            int count = 2;

            while(count < number){
                Console.WriteLine(+ count);
                count +=2;
            }
        }
    }
}

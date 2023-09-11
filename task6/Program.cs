// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int number = int.Parse(Console.ReadLine()!);

            if(number%2 == 0){
                Console.WriteLine("Да");
            }
            else{
                Console.WriteLine("Нет");
            }
        }
    }
}

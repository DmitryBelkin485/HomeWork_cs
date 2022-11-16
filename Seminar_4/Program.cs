// Урок 4. Функции продолжение

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Clear();
// Console.Write("enter number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("enter number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int Degree = numA;

// for (int i = 1; i < numB; i++)
// {
//     Degree *= numA;
// }
// Console.WriteLine($"A to degree B equals: {Degree} ");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Clear();
// int sum = 0;
// Console.Write("Enter number: ");
// String num = Console.ReadLine();
// for (int i = 0; i < num.Length; i++)
// {
//     string str;
//     str = Convert.ToString(num[i]);
//     int number = int.Parse(str);
//     sum += number;
// }
// Console.WriteLine($"sum= {sum}");
// // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

// Console.Clear();
// Console.Write("Enter number: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"sum of digits = {GetSumNums(num)}");

// int GetSumNums(int number)
// {
//     int sum = 0;
//     while (number > 0)      // 256 % 10 = 25,6 -> 6 >>> 25 % 10 = 2,5 -> 5 >>>  2 % 10 = 2 >>> result 2 +5 + 6 = 13 !!! 
//     {
//         sum += number % 10; //sum = sum + number % 10;
//         number /= 10;       //number = number / 10;
//     }
//     return sum;
// }




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// int[] array = { 1, 23, 345, 6789, 1011, 2011, 2033, 78 };
// Console.WriteLine($"[{String.Join(",", array)}]");
// // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

// Console.Clear();
// int[] array = GetRandomArray(8, 0, 100);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

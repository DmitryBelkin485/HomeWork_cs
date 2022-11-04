// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите 3х значное число: ");
// string number = Console.ReadLine();
// int amount = number.Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine($"Вторая цифра числа : {number[1]}");
// }



// // слегка друой вариант решения._ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
// Console.Write("Введите 3х значное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int amount = number.ToString().Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(middle(number));
// }

// int middle(int a)
// { 
//     int result = ((a / 10) % 10);
//     return result;
// }
// //_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _




// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


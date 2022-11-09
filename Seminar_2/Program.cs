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



// // // Другой вариант решения._ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
// Console.Write("Введите 3х значное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // //int amount = number.ToString().Length;

// if (Math.Abs(number) < 100 || Math.Abs(number) > 999)    // //(amount < 3 || amount > 3)  // // (amount != 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(middle(number));
// }

// int middle(int a)
// {
//     int result = (a / 10 % 10);   //((a / 10) % 10);
//     return result;
// }
//_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите номер: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(number) > 99)
// {
//     while (Math.Abs(number) > 999)
//     {
//         number = number / 10;
//     }
//     int thirdNum = number % 10;
//     Console.WriteLine(thirdNum);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет в числе");
// }

// // Другой вариант решения._ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

// Console.Clear();
// Console.Write("Введите 3х значное число: ");
// string number = Console.ReadLine();
// int amount = number.Length;

// if (amount < 3 || amount > 1000)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.WriteLine($"Вывод : {number[2]}");
// }

// // Другой вариант решения._ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

// Console.Clear();

// bool Third(string number)
// {
//     bool result = int.TryParse(number, out int Num);
//     return result;
// }

// Console.Write("Введите число: ");
// string number = Console.ReadLine();

// while (!Third(number))
// {
//     Console.Write("Вы ввели не число. Поробуйте снова: ");
//     number = Console.ReadLine();
// }
// Console.WriteLine((number.Length > 2 ? $"Третья цифра числа: {number[2]}" : "Без третьей цифры"));
// //_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// Console.Clear();

// Console.WriteLine("Введите день недели от 1 до 7: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(WorkWeek(a));


// string WorkWeek(int a)                        // string WorkHoliday(int day) 
// {
//     if (a > 0 && a < 8)                          //   if (day > 0 && day < 8) 
//     {
//         if (a == 6 || a == 7)                    //       if (day == 6 || day == 7)
//         {
//             Console.Write($"Ура, {a} это выходной");
//         }
//         else
//         {
//             Console.Write($"Жаль, но, {a} это рабочий");
//         }
//     }
//     else
//     {
//         Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
//     }
//     return " день! ";
// }
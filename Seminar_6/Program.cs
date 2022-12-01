// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Console.Clear();

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32); //int.Parse
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

// //Другой вариант:_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

// Console.Clear();

// int[] arr = CreateRandomArray(5, -100, 100);
// Console.WriteLine(String.Join(" ", arr));
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");


// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
// var: объявление переменной не определенно типа(Наткнулся решил попробовать ) (Мы говорим компилятору, чтобы он подобрал тип самостоятельно при компиляции.)

// Console.Clear();

// Console.Write("Введите b1: ");
// var b1 = double.Parse(Console.ReadLine()); //Convert.ToDouble(Console.ReadLine())  //int double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k1: ");
// var k1 = double.Parse(Console.ReadLine()); //Convert.ToDouble(Console.ReadLine())  //int double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = double.Parse(Console.ReadLine()); //Convert.ToDouble(Console.ReadLine())  //int double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = double.Parse(Console.ReadLine()); //Convert.ToDouble(Console.ReadLine())  //int double k2 = Convert.ToInt32(Console.ReadLine());

// var x = (b1 - b2)/(k2 - k1);
// var y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");



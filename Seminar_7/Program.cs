// // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.?
// Console.Clear();

// Console.WriteLine("Введите количество строк: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = int.Parse(Console.ReadLine());

// double[,] numbers = new double[m, n];
// Random rnd = new Random();

// FillArray(numbers);
// Console.WriteLine();
// PrintArray(numbers);

// void PrintArray(double[,] matr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] matr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
//         }
//     }
// }


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Clear();

// Console.Write("Введите индекс строки: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[6, 8];
// FillArray(numbers);
// PrintArray(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
// {
//     Console.WriteLine(numbers[rows, colums]);
// }
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 11);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.Clear();

// Console.Write("введите количество строк: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("введите количество столбцов: ");
// int m = int.Parse(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);


// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// PrintArray(numbers);



// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i ,j]}  ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }
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
//         for (int j = 0; j < n; j++)
//         { Console.Write($"{matr[i, j]} "); }
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] matr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//             { matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
//     }
// }


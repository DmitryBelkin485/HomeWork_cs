// //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Clear();

// Console.Write("Enter the size of the array: ");
// int size = int.Parse(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.Write("Array: ");
// PrintArray(numbers);
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
//     if (numbers[i] % 2 == 0)
//         count++;

// Console.WriteLine($"total {numbers.Length} numbers, {count} of them even.");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100, 1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write($"{numbers[i]} ");
//     }
//     Console.WriteLine("]");
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


// Console.Clear();

// Console.Write("Enter the size of the array: ");
// int size = int.Parse(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.Write("Array: ");
// PrintArray(numbers);
// int sum = 0;

// for (int i = 0; i < numbers.Length; i += 2)
//     sum += numbers[i];
// Console.Write($"total {numbers.Length} numbers, sum of elements in odd positions= {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(1, 10);
//     }
// }
// void PrintArray(int[] numbers)
// {

//     Console.Write("[");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write($"{numbers[i]} ");
//     }
//     Console.WriteLine("]");
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

// Console.Clear();

// Console.Write("Enter the size of the array: ");
// int size = int.Parse(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 1; i < numbers.Length; i++)
// {
//     if (numbers[i] > max) max = numbers[i];
//     else if (numbers[i] < min) min = numbers[i];
// }

// Console.WriteLine($"Minimum number: {min}");
// Console.WriteLine($"Maximum number: {max}");
// Console.WriteLine($"Difference between maximum and minimum numbers: {max - min}");



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 1000);
//     }
// }


// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
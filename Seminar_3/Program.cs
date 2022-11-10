// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("enter number: ");
// string number = Console.ReadLine();
// int len = number.Length;
// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Palindrome");
//     }
//     else
//     {
//         Console.WriteLine($"{number} -  Not a palindrome");
//     }
// }
// else
// {
//     Console.WriteLine($"ERROR: {number}- is not five digit");
// }





// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1, -7), -> 15.84

// A (7,-5, 0); B (1,-1, 9) -> 11.53

Console.Clear();

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string info)
{
    Console.Write(info);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Math.Round(length, 2));




// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1,8,27,64,125

// void sqrt(int N)
// {
//     if (N > 0)
//     {
//         int count = 1;
//         while (count < N)
//         {
//             int result = count * count * count;
//             Console.Write(result + ", ");
//             count++;
//         }
//         Console.Write(N * N * N);
//     }
//     else
//     {
//         Console.WriteLine("Введите число больше 1");
//     }
// }
// Console.WriteLine("enter number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// sqrt(N);


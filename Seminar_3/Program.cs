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

int x1 = ReadInt("Enter the X coordinate of the first point: ");
int y1 = ReadInt("Enter the Y coordinate of the first point: ");
int z1 = ReadInt("Enter the Z coordinate of the first point: ");
int x2 = ReadInt("Enter the X coordinate of the first point: ");
int y2 = ReadInt("Enter the Y coordinate of the first point: ");
int z2 = ReadInt("Enter the Z coordinate of the first point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double Length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Cut length {Length}");

int ReadInt(string info)
{
    Console.Write(info);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Math.Round(Length, 2));




// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1,8,27,64,125

// void Sqrt(int N)
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
//         Console.WriteLine("enter a number greater than 1");
//     }
// }
// Console.WriteLine("enter number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Sqrt(N);


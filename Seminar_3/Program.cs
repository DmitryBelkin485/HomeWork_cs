// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("enter number: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Palindrome");
    }
    else
    {
        Console.WriteLine($"{number} -  Not a palindrome");
    }
}
else
{
    Console.WriteLine($"ERROR: {number}- is not five digit");
}












// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

















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


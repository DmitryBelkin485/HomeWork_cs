Console.Clear();

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


// Console.Write("Введите первое число: ");
// int num_A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// if (num_A > num_B)
// {
//     Console.Write("Первое число: " + num_A + " Больше чем второе число: " + num_B);
// }
// else
// {
//     Console.Write("Второе число: " + num_B + " Больше чем первое число: " + num_A);
// }





// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.Write("Введите первое число: ");
// int num_A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num_C = Convert.ToInt32(Console.ReadLine());

// int max = num_A;

// if (num_B > max)
// {
//     max = num_B;
// }

// if (num_C > max)
// {
//     max = num_C;
// }

// Console.Write("Наибольшее из введенных чисел: " + max);





// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: НЕЧЕТНЫМ");
}
else
{
    Console.WriteLine("число " + num + " является: ЧЕТНЫМ");
}





// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
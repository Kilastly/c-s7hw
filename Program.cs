/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/
// void IntIn(int max, int min)
// {
//      Console.Write($"{max} ");
//     if (max == min)
//     {
//     return;
//     }
//         IntIn(max-1, min);


// }

// Console.Clear();    
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a < b)
//     {
//         IntIn(b, a);
//     }
// else
// {
// IntIn(a, b);
// }

/*
Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 
*/
// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1



int aсkPeter(int m, int n)
{
    while (m !=0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = aсkPeter(m, n-1);
        }
        m = m-1;
    }
        return n + 1;
}

Console.Clear();    
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
int result = aсkPeter(m, n);
Console.WriteLine($"Результат вычисления функции Аккермана = {result}");
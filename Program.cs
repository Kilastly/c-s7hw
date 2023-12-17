/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/
void IntIn(int max, int min)
{
     Console.Write($"{max} ");
    if (max == min)
    {
    return;
    }
        IntIn(max-1, min);
       
    
}

Console.Clear();    
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
if (a < b)
    {
        IntIn(b, a);
    }
else
{
IntIn(a, b);
}

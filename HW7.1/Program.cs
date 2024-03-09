// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ListNums(int n, int m)
{
    if (m >= n)
    {
        Console.Write($"{m} ");
        return;
    }
    Console.Write($"{m} ");
    ListNums(n, m + 1);
}
Console.Clear();
Console.Write("Введите от какого числа вывести натуральные числа: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите до какого числа вывести натуральные числа: ");
int n = Convert.ToInt32(Console.ReadLine());
ListNums(n - 1, m);
//Для выдачи чисел включая последнее для передачи в функцию убрать "-1"
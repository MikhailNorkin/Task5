/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] array = new int [4];
int a = 0;
Console.Write($"[");
for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(-99,100);
    Console.Write($"{array[i]} ");
    if (i % 2 != 0)
    {
        a = a + array[i];
    }
}
Console.WriteLine($"] -> {a}");
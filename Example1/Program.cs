// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int SumPositive(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positive += array[i];
    }

    return positive;
}

int SumNegative(int[] array)
{
    int negative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) negative += array[i];
    }

    return negative;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

Console.WriteLine();

Console.WriteLine("+ -> " + SumPositive(array));
Console.WriteLine("- -> " + SumNegative(array));

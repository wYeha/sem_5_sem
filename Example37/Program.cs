// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
    Console.WriteLine("]");
}

int[] Sum(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) resultArray[resultArray.Length - 1] = array[array.Length / 2];
    return resultArray;
}

int[] array = CreateArrayRndInt(4, 1, 9);
int[] result = Sum(array);
PrintArray(array);
PrintArray(result);
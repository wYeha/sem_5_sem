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

bool IfExists(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(10, -10, 10);
PrintArray(array);

Console.WriteLine("Введи число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

bool ifExists = IfExists(number, array);

Console.WriteLine(ifExists ? "Число присутствует!" : "Число отсутствует");
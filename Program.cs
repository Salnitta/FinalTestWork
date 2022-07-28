string[] CreateArray(int size)
{
    return new string[size];
}

void FillArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Please, enter string №{i + 1} of the input array:");
        array[i] = Console.ReadLine();
    } 
    Console.WriteLine();
}

int ElementsCounter(string[] array, int length)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) count++;
    }
    return count;
}

string[] MainTask(string[] array, string[] result, int length) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
        result[count] = array[i];
        count++;
        }
    }
    return result;
}

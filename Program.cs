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

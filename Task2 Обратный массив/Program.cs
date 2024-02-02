Console.WriteLine("Сколько чисел будет в массиве?");
int size = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] array = new int[size];

Console.Write("Сгенерированный массив: ");
PrintGenerationArray(array, rnd, 0);

Console.WriteLine();
Console.Write("Обратный массив: ");
PrintReverseArray(array, size - 1);

void PrintReverseArray(int[] numbers, int index)
{
    if (index >= 0)
    {
        Console.Write($"{numbers[index]} ");
        PrintReverseArray(array, index - 1);
    }
}

void PrintGenerationArray(int[] numbs, Random rnd, int currentIndex)
{
    if (currentIndex < numbs.Length)
    {
        numbs[currentIndex] = rnd.Next(1, 1001);
        Console.Write($"{numbs[currentIndex]} ");
        PrintGenerationArray(numbs, rnd, currentIndex + 1);
    }
}
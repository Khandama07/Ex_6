Console.WriteLine("введите длинну массива");
int arrLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите длинну подмассива");
int subArrLength = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[arrLength, subArrLength];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        if (i < arrLength - 1) Console.Write(", ");
    }
    Console.Write(" ]");
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
     { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +  " ");
        }
        Console.WriteLine();
    }
}

int[,] arr = new int [4,4] 
{
    {5, 2, 1, 14 },
    {8, 13, 10, 1 },
    {5, 1, 11, 5 },
    {3, 2, 1, 10 }
};

PrintArray(arr);

int MinSum = 1000;
int MinRow = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    int SumElementsInRow = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        SumElementsInRow = SumElementsInRow + arr[i, j];
    }
    Console.Write("Сумма элементов в " + (i+1) + " строке: " + SumElementsInRow);
    Console.WriteLine();
    if (SumElementsInRow < MinSum)
        {
            MinSum = SumElementsInRow;
            MinRow = i + 1;
        }
}

Console.WriteLine();
Console.WriteLine("Наименьшая сумма элементов: " + MinSum);
Console.Write("Cтрока с наименьшей суммой элементов: " + MinRow);
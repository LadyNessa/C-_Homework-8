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

void SortDataRows(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j +1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    int temporary = array[i, k];
                    array[i, k] = array[i, maxPosition];
                    array[i, maxPosition] = temporary;
                }
            }
        }
    }
}

int[,] arr = new int [3,4] 
{
    {4, 2, 1, 3 },
    {8, 3, 10, 1 },
    {5, 7, 11, 5 }
};

PrintArray(arr);
SortDataRows(arr);
Console.WriteLine("Массив после расстановки элементов в порядке убывания в каждой строке:");
PrintArray(arr);

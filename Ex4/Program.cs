void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
     { 
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] +  " ");
        }
        Console.WriteLine();
    }
}

int CheckElement(int[,] arr, int RandomNum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == RandomNum)
            {
                RandomNum = 0;
            }
        }
    }
    return RandomNum;
}

void FillArrayRandom(int[,] arr)
{
    Random random = new Random();
	for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            int RandomElement = random.Next(10, 99);
            RandomElement = CheckElement(arr, RandomElement);
            if (RandomElement == 0)
            {
                j--;
            }
            else
            {
                arr[i, j] = RandomElement;
            }
        }
    }
}

int[,] array = new int [5, 5];
FillArrayRandom(array);
PrintArray(array);
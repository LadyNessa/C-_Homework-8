void FillMatrix(int [,] matrix)
{
    Random random = new Random();
	for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 20);    
        }
    }
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
     { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] +  " ");
        }
        Console.WriteLine();
    }
}


int[,] matrix1 = new int [2, 2];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = new int [2, 2];
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] matrix3 = new int [2, 2];
int i = 0;
int j = 0;
matrix3[i, j] = matrix1[i, j] * matrix2[i,j] + matrix1[i, j+1] * matrix2[i+1, j];
matrix3[i+1, j] = matrix1[i+1, j] * matrix2[i, j] + matrix1[i+1, j+1] * matrix2[i+1, j];
matrix3[i, j+1] = matrix1[i, j] * matrix2[i, j+1] + matrix1[i, j+1] * matrix2[i+1, j+1];
matrix3[i+1, j+1] = matrix1[i+1, j] * matrix2[i, j+1] + matrix1[i+1, j+1] * matrix2[i+1, j+1];
PrintMatrix(matrix3);
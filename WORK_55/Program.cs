// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы

/*int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine(matrix[i , j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] TMatrix(int[,] matrix)
{
    int[,] matrix2 = new int [matrix.GetLength(1), matrix.GetLength(0)];
    
    for(int i = 0; i < matrix2.GetLength(0); i++)
    {
       for(int j = 0; j < matrix2.GetLength(1); j++)
       {
           matrix2[i , j] = matrix[j, i];
       }
       Console.WriteLine();
    }
    return matrix2;
}

const int ROWS = 3; // 3 СТРОКИ
const int COLUMNS = 4; // 4 СТОЛБЦА
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
int[,] matrix2 = TMatrix(array);
PrintMatrix(matrix2);*/










int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
int[,] matrix = new int[rows,columns];

for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + " ");
}
Console.WriteLine();
}
}

int[,] TMatrix(int[,] matrix)
{
int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];

for(int i = 0; i < matrix2.GetLength(0); i++)
{
for(int j = 0; j < matrix2.GetLength(1); j++)
{
matrix2[i, j] = matrix[j, i];
}
Console.WriteLine();
}return matrix2;
}

const int ROWS = 3; // 3 СТРОКИ
const int COLUMNS = 4; // 4 СТОЛБЦА
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
int[,] matrix2 = TMatrix(array);
PrintMatrix(matrix2);
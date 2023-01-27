// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива 

//                        строки     столбцы
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

void Change(int[,] matrix)
{
    int temp = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0 , j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

const int ROWS = 4; // 3 СТРОКИ
const int COLUMNS = 3; // 4 СТОЛБЦА
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
 PrintMatrix(array);
Console.WriteLine();
Change(array);
PrintMatrix(array);

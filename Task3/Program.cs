// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using static System.Console;
Clear();
Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters1 = GetArrayFromString(ReadLine()!);
int[,] matrix1 = GetMatrixArray(parameters1[0], parameters1[1], parameters1[2], parameters1[3]);
Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters2 = GetArrayFromString(ReadLine()!);
int[,] matrix2 = GetMatrixArray(parameters2[0], parameters2[1], parameters2[2], parameters2[3]);
PrintMatrix(matrix1);
WriteLine();
PrintMatrix(matrix2);
WriteLine("Результирующая матрица");
int [,] NewMatrix = UmnozhitMatrix(matrix1, matrix2);
PrintMatrix(NewMatrix);


int[,] UmnozhitMatrix(int[,] matr, int[,] matr2)
{
    int[,] newmatr = new int[matr.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(0); n++)
            {
                newmatr[i, j] = newmatr[i, j] + matr[i, n] * matr2[n, j];
            }
        
        }

    }
    return newmatr;
}

int[,] GetMatrixArray(int rows,int columns,int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}

int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for(int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}


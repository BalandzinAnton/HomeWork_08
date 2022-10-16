// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using static System.Console;
Clear();
Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
int [] Arr = RowSum(matrix);
PrintArray(Arr);
WriteLine();
int x = SaerchMinRow(Arr);
int index = Array.IndexOf(Arr, x);

WriteLine($"{index+1} строка");



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

int[] RowSum(int[,] INMatrix)
{
    int[] Array = new int[INMatrix.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < INMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < INMatrix.GetLength(1); j++)
        {
            sum = sum + INMatrix[i, j];

        }
        Array[i] = sum;
        sum = 0;
    } 
    return Array;  
}

void PrintArray(int[] array) //
{
    Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    WriteLine(" ");
}

int SaerchMinRow (int [] ArrayIn)
{
    int x = 0;
    int [] Arr = new int[ArrayIn.Length];
    int minValue = ArrayIn[0];
    for (int i = 1; i < ArrayIn.Length; i++)
    {
        if (ArrayIn[i]<minValue)
        {
            minValue = ArrayIn[i];
        }
    }
    return minValue;
}

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


using static System.Console;
Clear();
Write("Ввдеите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2]);
PrintMatrix(matrix);
WriteLine();

int[,,] GetMatrixArray(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    int check = default;
    int a = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2);)
            {
                a = rnd.Next(10, 100);
                bool Povtor;
                Povtor = false;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    for (int n = 0; n < matrix.GetLength(1); n++)
                    {
                        for (int m = 0; m < matrix.GetLength(2); m++)
                        {
                            
                            if(matrix[k, n, m] == a)
                            {
                                Povtor = true;
                                break;
                            }
                            
                        }
                
                    }
                }
            if(!Povtor)
            {
            matrix[i, j, z] = a;
            z++;
            }
            
            }
        } 
    } 
    return matrix;
}

void PrintMatrix(int[,,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int z = 0; z < inMatrix.GetLength(2); z++)
            {
            Write($"{inMatrix[i,j,z]}({i},{j},{z}) | ");
            }
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



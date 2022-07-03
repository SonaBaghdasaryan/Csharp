//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Write("Input the m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();
void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20- 10;
    }
  }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
*/


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] array = new int[4,3] {{6,7,1},{9,5,8},{5,2,3},{8,2,4}};
 
for (int i = 0; i < 3; i++) 
{
  int srAr = 0;
  for (int j = 0; j < 3; j++)
  {
    srAr += array[j, i];
  }
  Console.WriteLine($"Arithmetic mean of column elements is {i + 1} = {(float)srAr/3}");
}
*/



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
 
/*
int[,] CreateRandomTwoDemArray(int a, int b)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(10,100);


            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return newMatrix;
}


bool DigitExists (int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
   {
      if (value == array[i, j])
          return true;
   }
   
    }
    return false;
}
int[,] array1 = CreateRandomTwoDemArray(4,5);
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (DigitExists (array1, a))
{
    Console.WriteLine($"Number {a} exists in array");
}
else
{
    Console.WriteLine($"Number {a} does not exist in array");
}

*/

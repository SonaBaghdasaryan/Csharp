//Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива
/*
  int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] OrderTheElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] < array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}
int[,] array1 = CreateRandomTwoDimArray(3,4,1,9);
ShowTwoDimArray(array1);
Console.WriteLine();
ShowTwoDimArray(OrderTheElements(array1));
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
class Program
{
public static void CreateArray(int[,] myArray)
{
    Random rnd = new Random();
            
for(int i = 0; i < myArray.GetLength(0); i++) 
{
    Console.Write("\n{0}:", i);
    for(int j = 0; j < myArray.GetLength(1); j++) 
    {
        myArray[i, j] = rnd.Next(1, 9); 
        Console.Write("{0}  ", myArray[i, j]);
    }
}
}
static void Main(string[] args)
{
    int[,] myArray = new int[3,5];
    int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
    CreateArray(myArray);
 
    for(int i = 0; i < myArray.GetLength(0); i++) 
    {
        Sum2 = 0;
        for(int j = 0; j < myArray.GetLength(1); j++) 
        {   Sum2 += myArray[i, j];  } 
            if(Sum2 < Sum1)
        {   Sum = Sum2; Row = i;    }
            Sum1 = Sum2;
    }
    
    Console.WriteLine("\n\tThe sum of elements in row = {0} ", Sum);
    Console.WriteLine("\n\tThe string with minimal sum of elements = {0} ", Row);
 
        Console.ReadKey();
        }
    }
*/


//Заполните спирально массив 4 на 4
/*
void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SpiralMethodOfArray()
{
    int m = 5;
    int side = 1;
    int[,] result = new int[m,m];
    int num = 1;
    for (int k = 0; k < m - side * 2; k++)
    {
        for (int j = k; j < m - side - k; j++, num++)
            result[k,j] = num;
        for (int i = k; i < m - side - k; i++, num++)
            result[i,m - side - k] = num;
        for (int j = m - side - k; j >= k; j--, num++)
            result[m - side - k,j] = num;
        for (int i = m - side * 2 - k; i > k; i--, num++)
            result[i,k] = num;
    }
    return result;
}
int[,] myArray = SpiralMethodOfArray();
ShowTwoDimArray(myArray);
*/

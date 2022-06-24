//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write (newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int QuantityofEvenNumbers (int[] array)
{
    int quantity= 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 ) quantity++;
    }
    return quantity;
}

int[] array1 = CreateRandomArray(5, 100, 999);
int result = QuantityofEvenNumbers(array1);
Console.WriteLine(result);
Console.WriteLine("The quantity of even numbers is " + result);
*/


//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write (newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindSumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 !=0) sum += array [i];
        
    }
    return sum;
}
int[] array1 = CreateRandomArray(10, 10, 100);
Console.WriteLine("Sum of numbers of odd positions is: " + FindSumEven(array1));

*/


//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76



double[] FindDifference = new double[10];

for (int i = 1; i < FindDifference.Length; i++)
{
    FindDifference[i] = Math.Round(new Random().Next(3,10)+ new Random().NextDouble(),1);
    Console.Write(FindDifference[i] + " ");

}
double MaxNumber = FindDifference[0];
double MinNumber = FindDifference[0];
for (int i = 1; i < FindDifference.Length; i++)
{
    if(MaxNumber < FindDifference[i])
    {
        MaxNumber = FindDifference[i];
    }
    if(MinNumber > FindDifference[i])
    {
        MinNumber = FindDifference[i];
    }
        
}

double dif = MaxNumber - MinNumber;
Console.WriteLine($"The difference between max and min numbers is {dif}");




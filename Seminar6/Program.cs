//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Input the numbers by spaces: ");

int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"The numbers are > 0: {count}");

*/


//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] array = new int [8];
int[] arr = {1, 9, 8, 6, 4, 7, 4, 1};
int[] copy = new int[arr.Length];

for(int i = 0; i < arr.Length; i++)
{
   array[i] = new Random().Next(0,9);
   i++;
}

for(int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i];
}
 Console.WriteLine(String.Join(", ", copy));

 */
 
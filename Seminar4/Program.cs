// Task 1 Seminar 4

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
 int FindDegree(int numberA, int numberB)

 {
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
  result = result * numberA;
  }
     //int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Input number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int findDegree = FindDegree(numberA, numberB);
  Console.WriteLine("The answer is: " + findDegree);
   */



//Task 2 Seminar 4
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]

/*
int size = 8;
int[] array = new int [8];


for(int i = 0; i < size; i++)
{
   array[i] = new Random().Next(0,9);
   i++;
}

for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");

}
*/


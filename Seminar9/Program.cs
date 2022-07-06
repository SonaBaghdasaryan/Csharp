//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int SumOfElements(int M, int N)
    {
        if(M == N) return N;
        return N + SumOfElements(M, N-1);
    }
Console.Write("Input the number M ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number N ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfElements(a,b));



//Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
/*
int SumOfDigits(int number)
    {
        if(number==0) return 0;
        return number % 10 + SumOfDigits(number/10);
    }
Console.Write("Input the number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(a));

*/


/*
int CutNumber(int num) 

{

    int sot = num / 10; 
    int ed = num % 10;

    int res = num / 10 % 10;
    return res;
}

Console.Write("Input the three digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = CutNumber (a);

Console.WriteLine($"The second number is {result}");

*/




/*

int ThirdNumber(int num)

{
   if(num < 100)
   {
        Console.WriteLine("There is no third number");
        return -1;
   }
   else
   {

        while(num > 999)

        {

            num = num / 10;

        }

        int result = num % 10;

        return result;

   }

}

Console.WriteLine("Input the number: ");

int res = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ThirdNumber(result));

*/



/*

int FindWeekDay(int day)

{
    if(day<=5)
    {
   Console.WriteLine($"Рабочий день");
   int result = day;
   return result;

    }
else
    {

   Console.WriteLine($"Выходной");
   return -1;
    }
}

Console.WriteLine("Input the number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindWeekDay(a);

if (result == -1)

Console.WriteLine($"{ a }");


*/
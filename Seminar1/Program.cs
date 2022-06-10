/*

int a, b, max;

Console.WriteLine("Input the first number");
a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
b=Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    Console.WriteLine($"Max number is {a} ");
}

if (b > a)

{
    Console.WriteLine($"Max number {b} ");
}

*/

/*
int a, b, c;

Console.WriteLine("Input the first number");
a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the third number");
c=Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
  if (a > c)  
    {
        Console.WriteLine($"Max number is {a} ");
    }

}


if (b > a) 
{
    if (b > c)
    {
     Console.WriteLine($"Max number {b} ");
    }

}
    

if (c > a) 
{
    if (c > b)
    {
     Console.WriteLine($"Max number {c} ");
    }
    
}

*/


int a;
Console.WriteLine("Input the number");
a=Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("True");
}
else 
{
    Console.WriteLine("False");
}
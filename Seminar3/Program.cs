//Task 1

/*
Console.WriteLine("Input the five digit number");
 int x, x1, x2 = 0;

 var s = Console.ReadLine();            
 if (int.TryParse(s, out x))
    {
        if (s[0]=='0')Console.WriteLine($"That's not a natural number");
        else
       {
        x1 = x;
        while (x1 > 0)
            {
                x2 *= 10;
                x2 += x1 % 10;
                x1 /= 10;
            }
                if (x == x2) Console.WriteLine($"The number is palindrom");
                else Console.WriteLine($"The number is not palindrom");
        }
    }
        
 */


 //Task 2

/*
double FindDistance;

Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine(" Distance between two points in space.");

 {  
    Console.Write("Input the coordinats x1: ");
    x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input the coordinats y1: ");
    y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input the coordinats z1: ");
    z1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input the coordinats x2: ");
    x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input the coordinats y2: ");
    y2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input the coordinats z2: ");
    z2 = Convert.ToDouble(Console.ReadLine());
  } 

FindDistance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Distance between two points in space is {FindDistance}");
*/


//Task 3

/*
Console.WriteLine("Input the number");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int current= 1;
    while(current <=num)
    {
        Console.WriteLine((current*current*current) + "");
        current++;
    }
}

Cube(num);

*/

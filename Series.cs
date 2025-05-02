
using System;
class Series
{
static void Main()
{
Console.Write("Enter the number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Series of :");
for(int i =1;i<number;i++)
{
 int sqr =i * i ;
if(i% 2 ==0)
Console.Write($"-{sqr}");
else
Console.Write($"{sqr}");

if(number != sqr)
Console.Write(", ");

}
}
}
}

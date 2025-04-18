using System;
class Addsum
{
static void Main(){
Console.Clear();
Console.Write("Enter the 1st String");
string s1= Console.ReadLine("");
double d1=Convert.ToDouble(s1);
Console.Write("Enter the 2sr String");
string s2 = Console.ReadLine("");
double d2 = double.Parse(s2);
double d3=d1+d2;
Console.WriteLine("Sum of  "+ d1 + "&"+  d2  + "is :"+d3 ); 
}
}

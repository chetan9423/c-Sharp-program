using System;
class Aramstrongnum
{
static void Main()
{
Console.Write("Enter the number");
int num = int.Parse(Console.ReadLine());
int sum=0;
int temp=num;
while(num !=0)
{
int digit = num %10;
sum+=digit*digit*digit;
num=num/10;

}
if(temp==sum)
{
Console.WriteLine("Aramstrong number");
}
else
{
Console.WriteLine("not Aramstrong number");
}

}
}

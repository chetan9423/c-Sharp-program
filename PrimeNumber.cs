using System;
class PrimeNumber
{
static void Main()
{
Console.WriteLine("Enter the number");
uint Num=uint.Parse(Console.ReadLine());

if(Num==0 || Num==1)
{
Console.WriteLine("Enter the other number 0 and 1");
return;
}
bool isPrime=true;
uint HalfNum=Num/2;
for(uint i=2;i<=HalfNum;i++)
{
if(Num % i ==0)
{
isPrime=false;
break;
}
}
if(isPrime==true){
Console.WriteLine("This number is Prime");
}
else
Console.WriteLine("This number is not prime");
Console.WriteLine();
}
}

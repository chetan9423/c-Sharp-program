using System;
class PalindromeNo
{
   
static void Main()
{
 int num,temp,rev=0,rem;
Console.Write("Enter a integer \n");
num=Convert.ToInt32(Console.ReadLine());
temp = num;
while(num>0)
{
rem=num%10;
rev= rev*10+rem;
num=num/10;
}
Console.WriteLine("Given number is {0}",temp);
Console.WriteLine("Reverser number is {0}",rev);


if(temp==rev)
{
Console.WriteLine("Palindrome number");
}
else 
{
Console.WriteLine("Not palindrome number");
}
}

}

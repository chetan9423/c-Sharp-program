using System;
class AddTwoBinary
{
static void Main()
{
int b1,b2;
int i=0,rem=0;
int[] sum=new int[20];
Console.WriteLine("Enter the 1st binary number");
b1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the 2st binary number");
b2=int.Parse(Console.ReadLine());
while(b1!=0 || b2 != 0)
{
sum[i++] = (b1%10 + b2%10 + rem) % 2;
rem = (b1 %10 + b2 %10 + rem) / 2;
b1=b1/10;
b2=b2/10;
}
if(rem!= 0 ){
sum[i++] = rem;
}
i--;
Console.WriteLine("Sum of two binary Number");
while(i>=0){
Console.Write("{0}",sum[i--]);
}
Console.ReadLine();


}
}

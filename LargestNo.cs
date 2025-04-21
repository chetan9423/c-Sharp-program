using System;
class LargestNo
{
static void Main()
{
int a,b;
Console.Write("Enter The number :");
 a= Convert.ToInt32(Console.ReadLine());
 b= Convert.ToInt32(Console.ReadLine());

if(a>b)
{
Console.WriteLine("{0} is largest number",a);
}
else
{
Console.WriteLine("{0} is not largest number",b);
}


}
}

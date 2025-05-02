
using System;
class StudentMark
{
static void Main()
{
Console.Write("Enter the student name:");
string Name = Console.ReadLine();
Console.Write("Enter the Roll number");
int Rollnumber=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Mark of three subject");
int subject1=int.Parse(Console.ReadLine());
int subject2=int.Parse(Console.ReadLine());
int subject3=int.Parse(Console.ReadLine());

int total = subject1 + subject2 + subject3;
double Avg = total /3;

Console.WriteLine($"Total mark is {total}");
Console.WriteLine($"Average of mark {Avg}");
}
}

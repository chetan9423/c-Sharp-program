using System;
class DuplicateArray
{
public static void Main()
{
int[]num={0,1,1,1,2,2,3};

Console.WriteLine(MergeSortArray(num));
}
static int MergeSortArray(int[]num)
{
int i=0;
for(int j=0;j<num.Length;j++)
{
if(num[i]<num[j])
{
int temp=num[i+1];
num[i+1]=num[j];
num[j]=temp;
i++;

}
}
return i+1;
}
}

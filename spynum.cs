using System.Net.Http.Headers;

namespace Logical_Program
{
    internal class spynum
    {
       
        
        public string ISspy(int num)
        {
            int temp = num;
             int sum = 0;
            int Product = 1;
            
            for(int i=0;temp!=0;temp/=10)
            {
                int digit = temp % 10;
                sum += digit;
                Product *= digit;
                
            }

            if (sum == Product) 
            {
                return "Spy number";
            }
            else
            {
                return "NOt spy number";
            }
        }

       
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            spynum s = new spynum();
           string result =  s.ISspy(num);
            Console.WriteLine(result);
            
        }

              
            

            
    }
}

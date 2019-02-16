using System;

namespace increasing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=4;
            for (int i=1; i <= b; i++)
            
            {   
                int a=i;     
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}

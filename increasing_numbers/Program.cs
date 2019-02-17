using System;

namespace increasing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=10;
            for (int i=1; i <= b; i++)
            
            {   
                int a=i;
                int c=1;
                    if (i%2==0)     
                    {
                        c=i;
                        for (int j = c; j <= a;j--)
                        {   
                            if (j==1)
                        {
                            Console.Write("{0} ",j);
                            break;
                        }
                            Console.Write("{0}*",j);                   
                        }
                        Console.WriteLine();
                    }
                    else{
                        for (int j = 1; j <= a;j++)
                    {   
                    if (j==a)
                        {
                            Console.Write("{0} ",j);
                            break;
                        }
                    Console.Write("{0}*",j);                   
                }
                Console.WriteLine();
                    }
            }
        }    
    }
}

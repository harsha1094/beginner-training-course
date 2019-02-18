using System;
using System.Collections.Generic;

namespace Problematic
{
    class Program
    {
        static void Main(string[] args)
        {
            int skip=1;
            List<int> Range = new List<int>();
                for(int i=0;i<=5*skip;i=i+skip)
                    {
                        if (i==0){
                            Range.Add(1);
                            }
                        else{
                            Range.Add();
                            }
                    }
            Console.WriteLine(Range);
        }
    }
}

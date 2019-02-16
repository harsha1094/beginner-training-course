using System;
using System.Collections.Generic;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Person1  = new List<string>{"Sri","Harsha"};
            List<string> Person2  = new List<string>{"Bahu","Max"};
            List<string> Person3  = new List<string>{"Narun","Mod"};
            List<string> Person4  = new List<string>{"Cath","Bella"};
            List<string> Person5  = new List<string>{"Raul","Gol"};
            List<List<string>> listofpeople  = new List<List<string>>(Person1,Person2,Person3,Person4,Person5);
            int loopie = 5; 

            for (int a = 0; a <= 4; a = a + 1)
            {
                email(,,loopie);
            } 
        }
        static void email(string a1,string b1,int b11)
        {
            for (int a = 1; a <= b11; a = a + 1)
            {
                Console.WriteLine(a1+"."+b1+"@gmail.com");
            }
        }
    }
}

using System;
using System.Collections.Generic;

// namespace Program
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string a;
//             a="HELO";
//             thisprint(a);
//         }

//         static void thisprint(string str1)
//         {
//             Console.WriteLine(str1);
//         }
//     }
// }

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var string_f = new List<string>() {"Sri","Boohubal","Nahendra","Bella","Rauul"};
            var string_l = new List<string>() {"Whorsha","Minimum","mothi","Cat","Gandi"};
            int loopie = 5; 

            for (int a = 0; a <= 4; a = a + 1)
            {
                email(string_f[a],string_l[a],loopie);
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

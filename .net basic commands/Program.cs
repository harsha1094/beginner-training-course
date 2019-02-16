using System;
/* 
 comment
*/
namespace beginner_training_course
{
    class Program
    {
        /* 
        ! Main always runs first, there can only be one main in a Program
        */
        static void Main(string[] args)
        {
            fluffyy();
            /* 
            ! Methods and other classes can be called within this class provide the class is public.
            ? Also the variables can be reassigned as beloe
            */  
            Program2.a="Doggie1"
            Program2.Pro2();

            Program2.a="Doggie2"
            Program2.Pro2();
        }

        /* 
        ?  All other methods can be called inside the main()
        */
        static void fluffyy()
        {
            Console.WriteLine("Hello Fluffyy!");
            /* 
            ? other methods can be called within methods to make the program structure easy and tidy
            */
            fluffyy2();
            fluffyy3();
        }

        static void fluffyy2()
        {
            string a;
            a = "Hello Fluffyy4";
            fluffyy4(a);
        }

        static void fluffyy3()
        {
            fluffyy4("Hello Fluffyy3");
        }

        static void fluffyy4(string strong)
        /* 
        ? Method can be used to reuse code in different methods as below.
        */
        {
            Console.WriteLine(strong);
            Console.WriteLine(strong);
            Console.WriteLine(strong);
            Console.WriteLine(strong);
            Console.WriteLine(strong);
            Console.WriteLine(strong);
         }
    }

    public class Program2
    {
        string a;
        public static void Pro2 ()
        {
            Console.WriteLine("Hello Pro2!");
        }
    }
}

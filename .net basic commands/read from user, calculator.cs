using System;
static void Main(string[] args)
        {
            /*
            ! USE DOUBLE INSTEAD OF FLOAT to read user input easier.
            */
            double a,b;
            Console.WriteLine("Enter First Number: ");
            Console.WriteLine("Enter Second Number: ");
            /*
            ? Converting user input from string to double.
            */
            a=Convert.ToDouble(Console.ReadLine());
            b=Convert.ToDouble(Console.ReadLine());
            sum(a,b);
            sub(a,b);
            div(a,b);
            mod(a,b);
            mul(a,b);
        }
/*
? ADDITION
 */
        static void sum(double a,double b)
        {
            double c=a+b;
            Console.WriteLine("The Summation is {0}",c);
        }
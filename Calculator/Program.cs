using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            Console.WriteLine("Enter First Number: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
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
/*
? SUBTRACTION
 */
        static void sub(double a,double b)
        {
            double c=a-b;
            Console.WriteLine("The Subtraction is {0}",c);
        }
/*
? DIVISION
 */
        static void div(double a,double b)
        {
            double c=a/b;
            Console.WriteLine("The Division is {0}",c);
        }
/*
? MODULO
 */
        static void mod(double a,double b)
        {
            double c=a%b;
            Console.WriteLine("The Modulo is {0}",c);
        }
/*
? MULTIPLICATION
 */
        static void mul(double a,double b)
        {
            double c=a*b;
            Console.WriteLine("The Multiplication is {0}",c);
        }
    }
}

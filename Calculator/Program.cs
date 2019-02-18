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
            Console.WriteLine("The Addition is {0}",sum(a,b));
            Console.WriteLine("The Subtraction is {0}",sub(a,b));
            Console.WriteLine("The Division is {0}",div(a,b));
            Console.WriteLine("The Modulo is {0}",mod(a,b));
            Console.WriteLine("The Multiplication is {0}",mul(a,b));
        }
/*
? ADDITION
 */
        static double sum(double a,double b)
        {
            double c=a+b;
            return c;
        }

/*
? SUBTRACTION
 */
        static double sub(double a,double b)
        {
            double c=a-b;
            return c;
        }
/*
? DIVISION
 */
        static double div(double a,double b)
        {
            double c=a/b;
            return c;
        }
/*
? MODULO
 */
        static double mod(double a,double b)
        {
            double c=a%b;
            return c;
        }
/*
? MULTIPLICATION
 */
        static double mul(double a,double b)
        {
            double c=a*b;
            return c;
        }
    }
}

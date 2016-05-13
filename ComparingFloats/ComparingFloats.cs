/*
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

*/
using System;

class ComparingFloats
{
    static void Main()
    {
        decimal a;
        decimal b;
        decimal eps = 0.000001M;
        string aString;
        string bString;
        decimal calc;

        Console.WriteLine("Please enter first nuber to compare:");
        aString = Console.ReadLine();

        Console.WriteLine("Please enter second number to compare:");
        bString = Console.ReadLine();
        
                
        if (decimal.TryParse(aString, out a)&&(decimal.TryParse(bString, out b)))
        {
            calc = Math.Abs(a - b);
            if (calc < eps)
            {
                Console.WriteLine("The numbers {0} and {1} are considered equal, with difference of {2} which is less then eps ({3}).", aString, bString, calc, eps);
            }
            else if (calc == eps)
            {
                Console.WriteLine("The numbers {0} and {1} are considered not equal (bordercase), as the difference of {2} is equal to eps ({3}).", aString, bString, calc, eps);
            }
            else
            {
                Console.WriteLine("The numbers {0} and {1} are considered not equal, as the difference of {2} is more then eps ({3}).", aString, bString, calc, eps);
            }
        }
        else
        {
            Console.WriteLine("Not correctly formated input");
        }
           
    }
}


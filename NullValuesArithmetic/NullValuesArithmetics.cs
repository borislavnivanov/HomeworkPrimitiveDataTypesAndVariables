/*
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;


class NullValuesArithmetics
{
    static void Main()
    {
        int? number1 = null;
        double? number2 = null;
        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + null;
        number2 = number2 + null;
        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + 10;
        number2 = number2 + 10.32;
        Console.WriteLine("{0};{1}", number1, number2);

        number1 = number1 + 10;
        number2 = number2 + 10.32;
        Console.WriteLine("{0};{1}", number1.GetValueOrDefault(), number2.GetValueOrDefault());


    }
}


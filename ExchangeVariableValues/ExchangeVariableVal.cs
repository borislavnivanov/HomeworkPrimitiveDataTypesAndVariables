/*
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some
programming logic.
Print the variable values before and after the exchange.
*/

using System;


class ExchangeVariableVal
{
    static void Main()
    {
        int value1 = 5;
        int value2 = 10;
        Console.WriteLine("Before the exchange:");
        Console.WriteLine("\tThe value of integer 1 is: {0},\n\tThe value of integer 2 is: {1}.",value1,value2);
        int value3 = value1;
        value1 = value2;
        value2 = value3;
        Console.WriteLine("After the exchange:");
        Console.WriteLine("\tThe value of integer 1 is: {0},\n\tThe value of integer 2 is: {1}.", value1, value2);
    }
}


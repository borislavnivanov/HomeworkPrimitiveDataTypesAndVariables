//Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is los

using System;

class FloatOrDouble
{
    static void Main()
    {
        double value1 = 34.567839023;
        float value2 = 12.345F;
        double value3 = 8923.1234857;
        float value4 = 3456.091f;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}",value1,value2,value3,value4);
    }
}


/*
Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
*/


using System;

class QuotesInString
{
    static void Main()
    {
        string variant1 = "The \"use\" of quotations causes difficulties.";
        string variant2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(variant1);
        Console.WriteLine(variant2);
    }
}


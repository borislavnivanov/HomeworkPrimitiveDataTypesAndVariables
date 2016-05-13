/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.
*/

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName;
        string lastName;
        byte age;
        char gender;
        long personalID;
        long UniqueNumber;

        firstName = "Ivan";
        lastName = "Ivanov";
        age = 45;
        gender = 'm';
        personalID = 8306112507;
        UniqueNumber = 27560256;

        Console.WriteLine("Nemes:\t\t\t{0} {1}\nAge:\t\t\t{2}\nGender:\t\t\t{3}\nPersonal ID number:\t{4}\nUnique employee number: {5}",firstName,lastName,age,gender,personalID,UniqueNumber);
    }
}


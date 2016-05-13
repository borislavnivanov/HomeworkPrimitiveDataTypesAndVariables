/*
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/
using System;


class BankAccountData
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastname;
        string bankName;
        decimal balance;
        string currency;
        string IBAN;
        string BIC;
        long creditCard1;
        long creditCard2;
        long creditCard3;

        firstName = "Ivan";
        middleName = "Aleksandrov";
        lastname = "Ivanov";
        bankName = "RBB (Raiffeisen Bank Bulgaria EAD)";
        balance = 4852.28M;
        currency = "BGN";
        IBAN = "BG45RZBB52468954731563";
        BIC = "RZBBBGSF";
        creditCard1 = 3525164628596324;
        creditCard2 = 3526352245824769;
        creditCard3 = 3526755496358244;

        Console.WriteLine("Client Name:\t\t\t {0} {1} {2}\nBank Name:\t\t\t {3}\nAvailalbe amount (balance):\t {4} {5}\nCurrent account IBAN:\t\t {6}\nBank identification code BIC:\t {7}\nCredit card number:\t\t {8}\nCredit card number:\t\t {9}\nCredit card number:\t\t {10}", firstName,middleName,lastname,bankName,balance,currency,IBAN,BIC,creditCard1,creditCard2,creditCard3);
      
    }
}

// Program.cs
using System;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount("John Doe", 1000);

        myAccount.PrintAccountDetails();

        myAccount.Deposit(500);
        myAccount.Withdraw(200);

        myAccount.PrintAccountDetails();
    }
}

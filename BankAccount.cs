// BankAccount.cs
using System;

public class BankAccount
{
    private string accountHolder;
    private double balance;

    public BankAccount(string holder, double initialBalance)
    {
        accountHolder = holder;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public void PrintAccountDetails()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: ${balance}");
    }
}

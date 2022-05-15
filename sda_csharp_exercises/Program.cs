using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new();
            account.IncreaseBalance(100);
            SavingAccount savingAccount = new();
            savingAccount.IncreaseBalance(200);
            savingAccount.IncreaseInterests(0.20M);
            Bank bank = new();
            bank.AddAccount(account);
            bank.AddAccount(savingAccount);
            Console.WriteLine($"Total amount: {bank.GetTotalAmount()}");
        }
    }
}
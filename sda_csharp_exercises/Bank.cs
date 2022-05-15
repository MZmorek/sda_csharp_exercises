using System;

namespace sda_csharp_exercises_classes
{
    class Bank
    {
        private const int MAX_ACCOUNTS = 10;
        private Account[] accounts;
        public Bank()
        {
            accounts = new Account[MAX_ACCOUNTS];
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] is null)
                {
                    accounts[i] = account;
                    return;
                }
            }
            Console.WriteLine("Bank is full");
        }
        public decimal GetTotalAmount()
        {
            decimal sum = 0;
            foreach (var account in accounts)
            {
                if (account is not null)
                {
                    sum += account.Amount;
                }
            }
            return sum;
        }
    }
}
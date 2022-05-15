namespace sda_csharp_exercises_classes
{
    class Account
    {
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public virtual void IncreaseBalance(decimal increase)
        {
            balance += increase;
        }
        public virtual decimal Amount
        {
            get
            {
                return balance;
            }
        }


    }
}
namespace sda_csharp_exercises_classes
{
    class SavingAccount : Account
    {
        private decimal interests;
        public decimal Interests
        {
            get
            {
                return interests;
            }
        }
        public void IncreaseInterests(decimal increase)
        {
            interests += increase;
        }
        public override decimal Amount => base.Amount * (interests + 1);
    }
}
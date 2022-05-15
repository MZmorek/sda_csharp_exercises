using System;

namespace sda_csharp_exercises
{
    class Person
    {
        const int PROPER_AGE = 18;
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
            }
        }
        public string LastName { get; set; }

        public int YearOfBirth { get; set; }
        public bool IsAdult => (DateTime.Now.Year) - YearOfBirth >= PROPER_AGE;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {firstName} {LastName}");
        }

        //public bool IsAdult()
        //{
        //    if (DateTime.Now.Year - YearOfBirth >= PROPER_AGE)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

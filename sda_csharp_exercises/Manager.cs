using System;
using System.Net;

namespace sda_csharp_exercises
{
    sealed class Manager : Employee
    {
        public Manager(string firstName, string lastName, int yearOfBirth, decimal salary)
            : base(firstName, lastName, yearOfBirth, salary) { }

        public override decimal GetTotalSalary()
        {
            return Salary * 1.10M;
        }
    }
}
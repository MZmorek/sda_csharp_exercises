using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string password1 = "Bezpieczn3Hasl*";
            string password2 = "nieprawidlowe";
            Console.WriteLine(CheckPasswordRequirements(password1));
            Console.WriteLine(CheckPasswordRequirements(password2));
        }
        static bool CheckPasswordRequirements(string password)
        {
            return CheckDigits(password) && CheckLength(password) && CheckLetterSize(password) && CheckSpecialSigns(password);
        }
        static bool CheckLength(string password)
        {
            return password.Length >= 6;
        }
        static bool CheckDigits(string password)
        {
            char[] chars = password.ToCharArray();
            int numberOfDigits = 0;
            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                {
                    numberOfDigits++;
                }
            }
            return numberOfDigits > 0;
        }
        static bool CheckLetterSize(string password)
        {
            int lowerCount = 0;
            int upperCount = 0;
            char[] chars = password.ToCharArray();
            foreach (char c in chars)
            {
                if (char.IsUpper(c))
                {
                    upperCount++;
                }
                else if (char.IsLower(c))
                {
                    lowerCount++;
                }
            }
            return lowerCount > 0 && upperCount > 0;
        }
        static bool CheckSpecialSigns(string password)
        {
            int specialCount = 0;
            char[] chars = password.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '&' || chars[i] == '*' || chars[i] == '$' || chars[i] == '#')
                {
                    specialCount++;
                }
            }
            return specialCount > 0;
        }
    }
}

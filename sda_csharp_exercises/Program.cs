using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Asia";
            string text2 = "4$14";
            Console.WriteLine(TextToL33t(text1));
            Console.WriteLine(L33tDecoder(text2));
        }
        static string TextToL33t(string text)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            text = text.ToLower();
            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < naturalLetters.Length; j++)
                {
                    if (chars[i] == naturalLetters[j])
                    {
                        chars[i] = leetLetters[j];
                    }
                }
            }
            return new string(chars);
        }

        static string L33tDecoder(string text)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

            text = text.ToLower();
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < leetLetters.Length; j++)
                {
                    if (chars[i] == leetLetters[j])
                    {
                        chars[i] = naturalLetters[j];
                    }
                }
            }
            return new string(chars);
        }
    }
}

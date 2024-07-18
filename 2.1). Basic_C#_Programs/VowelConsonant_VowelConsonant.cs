using System;

namespace VowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i;
            int len;

            int vow = 0, cons = 0;

            str = Console.ReadLine();

            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o'
                    || str[i] == 'u' || str[i] == 'A' || str[i] == 'E'
                    || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vow++;
                }
                else if ( (str[i] >= 'a' && str[i] <= 'z') || (str[i]>='A' && str[i]<='Z'))
                {
                    cons++;
                }
            }

            Console.Write("\n Total Vowels are" +vow);
            Console.Write("\n Total Consonants are" +cons);
        }
    }
}

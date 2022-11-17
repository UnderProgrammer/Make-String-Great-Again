using System;

namespace Make_String_Great_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Solution
    {
        //todo: даделат
        public string MakeGood(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char x = s[i];
                char y = s[i + 1];
                if (IsBad(x, y) == true)
                {
                    s.Replace(x, ' ');
                    s.Replace(y, ' ');
                }
            }
            return s;
        }

        public bool IsBad(char x, char y)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            string ABC = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int i = IndexOf(abc, ABC, x);
            if (i == -1)
            {
                return false;
            }
            if (x == abc[i] && y == ABC[i] || x == ABC[i] && y == abc[i])
            {
                return true;
            }
            return false;
        }

        public int IndexOf(string s, string S, char a)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == a)
                {
                    return i;
                }
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

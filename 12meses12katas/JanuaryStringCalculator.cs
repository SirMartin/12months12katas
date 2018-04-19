using System;

namespace _12meses12katas
{
    public class JanuaryStringCalculator
    {
        public static int Add(string s)
        {
            var chars = s.ToCharArray();

            if (chars.Length == 0)
                return 0;

            int sum = 0, i = 0;
            var number = "";
            var c = chars[i];
            while (i < chars.Length)
            {
                while (IsNumber(c.ToString()))
                {
                    number += c.ToString();
                    i++;
                    if (i >= chars.Length)
                        break;
                    c = chars[i];
                }
                sum += Convert.ToInt32(number);
                i++;
                c = chars[i];
            }

            return sum;
        }

        public static bool IsNumber(string s)
        {
            int res;
            return int.TryParse(s, out res);
        }
    }
}
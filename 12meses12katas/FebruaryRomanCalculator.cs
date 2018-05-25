using System.Collections.Generic;

namespace _12meses12katas
{
    public class FebruaryRomanCalculator
    {
        public static List<Romans> Romans = new List<Romans>
        {
            new Romans("M", 1000),
            new Romans("D", 500),
            new Romans("C", 100),
            new Romans("L", 50),
            new Romans("X", 10),
            new Romans("V", 5),
            new Romans("I", 1)
        };


        public static string Calculate(int number)
        {
            var splitted = SplitNumber(number);
            var result = TranslateThousands(splitted.Count >= 4 ? splitted[3] : 0);
            result += TranslateHundreds(splitted.Count >= 3 ? splitted[2] : 0);
            result += TranslateTens(splitted.Count >= 2 ? splitted[1] : 0);
            result += TranslateUnits(splitted.Count >= 1 ? splitted[0] : 0);
            return result;
        }
        
        private static List<int> SplitNumber(int number)
        {
            var result = new List<int>();
            int multiplier = 1;
            var chars = number.ToString().ToCharArray();
            for(var i = chars.Length - 1; i >= 0; i--)
            {
                result.Add(int.Parse(chars[i].ToString()) * multiplier);
                multiplier *= 10;
            }

            return result;
        }

        private static string TranslateUnits(int number)
        {
            string res = "";
            if (number >= 1 && number <= 3)
            {
                while (number > 0)
                {
                    res += "I";
                    number--;
                }
            }

            if (number == 4)
                res = "IV";

            if (number >= 5 && number <= 8)
            {
                res = "V";
                number = number - 5;
                while (number > 0)
                {
                    res += "I";
                    number--;
                }
            }

            if (number > 8)
            {
                res = "X";
                int tempNumber = 10;
                while (tempNumber > number)
                {
                    res = "I" + res;
                    tempNumber--;
                }
            }

            return res;
        }

        private static string TranslateTens(int number)
        {
            string res = "";
            if (number >= 10 && number <= 30)
            {
                while (number > 0)
                {
                    res += "X";
                    number = number - 10;
                }
            }

            if (number == 40)
                res = "XL";

            if (number >= 50 && number <= 80)
            {
                res = "L";
                number = number - 50;
                while (number > 0)
                {
                    res += "X";
                    number = number - 10;
                }
            }

            if (number > 80)
            {
                res = "C";
                int tempNumber = 100;
                while (tempNumber > number)
                {
                    res = "X" + res;
                    tempNumber = tempNumber - 10;
                }
            }

            return res;
        }

        private static string TranslateHundreds(int number)
        {
            string res = "";
            if (number >= 100 && number <= 300)
            {
                while (number > 0)
                {
                    res += "C";
                    number = number - 100;
                }
            }

            if (number == 400)
                res = "CD";

            if (number >= 500 && number <= 800)
            {
                res = "D";
                number = number - 500;
                while (number > 0)
                {
                    res += "C";
                    number = number - 100;
                }
            }

            if (number > 800)
            {
                res = "M";
                int tempNumber = 1000;
                while (tempNumber > number)
                {
                    res = "C" + res;
                    tempNumber = tempNumber - 100;
                }
            }

            return res;
        }

        private static string TranslateThousands(int number)
        {
            string res = "";
            if (number >= 1000 && number <= 3000)
            {
                while (number > 0)
                {
                    res += "M";
                    number = number - 1000;
                }
            }

            return res;
        }
    }

    public class Romans
    {
        public Romans(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set; }
        public int Value { get; set; }
    }
}

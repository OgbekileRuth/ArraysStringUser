using System;

namespace ArraysStringUser
{
    internal class ArraysStringUsers
    {
        public static string ConcatenateStrings_Two(string first, string second)
    {
            return first + second;    
    }
    public static string ConcatenateStrings_two(string first, string second)
        {
            return first + second;
        }
        public static void SubstringOperation()
        {
            string f = "ScreenRecord";
            int startIndex = 6;
            int length = 6;
            Console.WriteLine(f.Substring(startIndex,length));
           
            string s = "Bluetooth";
            int startIndex2 = 0;
            int length2 = 4;
            Console.WriteLine(s.Substring(startIndex2, length2));
        }

    
        public static void ReplaceString()
        {
            string str = "Blue Tooth";
            string replaced = str.Replace("Tooth", "Sea");
            Console.WriteLine(replaced);
        }

        public static void SearchSubstring()
        {
            string str = "Blue Tooth";
            int index = str.IndexOf("Tooth");

            Console.WriteLine($"Index of 'Tooth': {index}");

            bool containsooth = str.Contains("ooth");
            Console.WriteLine($"Contains 'ooth': {containsooth}");

            bool containsSea = str.Contains("Sea");
            Console.WriteLine($"Contains 'Sea': {containsSea}");
        }
        public static void ComparisonofString()
        {
            string s1 = "Blue", s2 = "Blue";
            bool areEqualOne = s1 == s2; // Case-sensitive comparison
            bool areEqualTwo = s1.Equals(s2, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Case-sensitive comparison: {areEqualOne}");
            Console.WriteLine($"Case-sensitive comparison: {areEqualTwo}");

        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStringUser
{
    internal class StringManipulation
    {
        public static void StringReversal()
        {

        string s = "Chewing Stick";
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine(reversed);

        }

        public static void StringTrim()
        {

            string text = "$$$RonynAcademy$$$";
            string cleaned = text.Trim('$');
            Console.WriteLine($"'{cleaned}'");
        }

        public static void StringTrimI()
        {

            string I = "  Ice cream  ";
            string cleanedI = I.TrimStart();
            Console.WriteLine($"'{cleanedI}'");
        }

        public static void StringTrimII() 
        { 
            string II = "  Ice Cream  ";
            string cleanedII = II.TrimEnd();
            Console.WriteLine($"'{cleanedII}'");
        }

        public static void StringFormat()
        {
            string name = "Sarian";
            int age = 30;
            string result = string.Format("Hello {0}, you are {1} years old.", name, age);
            Console.WriteLine(result);


            DateTime today = DateTime.Now;
            string solution = string.Format("Today is {0:dd/MM/yyyy}", today);
            Console.WriteLine(solution);
        }

        public static void StringSplit()
        {
            string sentence = "BrightStar Academy Python Class";
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            
             Console.WriteLine(word);
            
        }
       
    }
}

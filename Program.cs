using System;

namespace ArraysStringUser
{
    internal class Program
    {
     static void Main(string[] args)
    {
                 
            string s1 = "Screen";
            string s2 = "Record";

            var resultThree = ArraysStringUsers.ConcatenateStrings_two(s1, s2);
            Console.WriteLine(resultThree);
            
            string Ap1 = "Blue";
            string Ap2 = "Tooth";

            var resultThreeKpi = ArraysStringUsers.ConcatenateStrings_two( Ap1, Ap2);
            Console.WriteLine(resultThreeKpi);

            ArraysStringUsers.SubstringOperation();
            ArraysStringUsers.SearchSubstring();
            ArraysStringUsers.ReplaceString();
            ArraysStringUsers.ComparisonofString();
        }
        
        }
    }
    

       
   


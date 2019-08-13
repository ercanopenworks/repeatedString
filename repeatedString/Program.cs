using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatedString
{
    class Program
    {

        static long repeatedString(string s, long n)
        {

            //classic solution

            //int i = 0;
            //long lCountA = 0, rCountA = 0;
            //long sTimes = n / s.Length;
            //long remainChars = n % s.Length;

            //if (remainChars > 0)
            //{
            //    for (; i < remainChars; i++)
            //    {
            //        if (s[i] == 'a') lCountA++;
            //    }
            //}
            //if (sTimes > 0)
            //{
            //    for (; i < s.Length; i++)
            //    {
            //        if (s[i] == 'a') rCountA++;
            //    }
            //}
            //return sTimes * (rCountA + lCountA) + lCountA;

            //linq solution
            char l = 'a';
            long repCount = 0;
            repCount = s.Count(c => c == l) * (n / s.Length) + s.Take((int)(n % s.Length)).Count(c => c == l);

            return repCount;


        }

        static void Main(string[] args)
        {

            //string s = Console.ReadLine();

            //long n = Convert.ToInt64(Console.ReadLine());


            string s = "aab";
            long n = 882787;
            long result = repeatedString(s, n);
        }
    }
}

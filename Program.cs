using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            string nflTeam = "San Diego Chargers";

            Console.WriteLine("Are these strings equal? {0}", nflTeam.Equals("San Diego Chargers"));
            Console.WriteLine("Are these strings equal? {0}", nflTeam.Equals("Green Bay Packers"));

            Console.WriteLine("Uppercase: {0}", nflTeam.ToUpper());
            Console.WriteLine("Lowercase: {0}", nflTeam.ToLower());

            nflTeam = "  " + nflTeam + "   ";
            Console.WriteLine("Before Trimming: |{0}|", nflTeam);
            nflTeam = nflTeam.Trim();
            Console.WriteLine(" After Trimming: |{0}|", nflTeam);

            Console.WriteLine("The string is {0} characters long. ", nflTeam.Length);

            Console.WriteLine("The first characer is {0}", nflTeam.ElementAt(0));
            Console.WriteLine("The last characer is {0}", nflTeam.ElementAt(17));

            Console.WriteLine("The first two words are {0}.", nflTeam.Substring(0,9));
            Console.WriteLine("The last word is {0}.", nflTeam.Substring(10));

            Console.WriteLine("The letter 'o' is located at {0}", nflTeam.IndexOf("o"));
            Console.WriteLine("The letter 'n' and 'i' is located at {0} and {1}", nflTeam.IndexOf("n"), nflTeam.IndexOf("i"));

            Console.WriteLine("Comparison(San Diego Raiders)? {0}", nflTeam.CompareTo("San Diego Raiders"));
            Console.WriteLine("Comparison(Los Angeles Chargers)? {0}", nflTeam.CompareTo("Los Angeles Chargers"));
            Console.WriteLine("Comparison({1})? {0}", nflTeam.CompareTo(nflTeam), nflTeam);


            //Break to Read
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReymonV2_2.Classes
{
    public class Home
    {
        public static void Main()
        {
            
            while(true)
            {

                // input-1 
                Console.Write("First String[exit-0]: ");
                var userData1 = Console.ReadLine();

                // exit
                if (userData1 == "0" || userData1 == "exit")
                    break;

                // input-2
                Console.Write("Secend String: ");
                var userData2 = Console.ReadLine();

                // get patterns
                var userPattern1 = HelperMain.FindPatterns(userData1);

                var userPattern2 = HelperMain.FindPatterns(userData2);


                // check patterns
                if(userPattern1 == userPattern2)
                {
                    Console.WriteLine("Same[True]");
                    Console.WriteLine("- - - - -");
                }
                else
                {
                    Console.WriteLine("NotSame[False]");
                    Console.WriteLine("- - - - -");
                }
            }
        }
    }

    public class HelperMain
    {
        // single responsibility
        public static string FindPatterns(string data )
        {
            // pattern
            var pattern = "";

            // a b c d
            for(int i = 0; i < data.Length; ++i)
            {
                for (int j = i + 1; j < data.Length ; j++)
                {
                    if (data[i] == data[j])
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += "-";
                    }
                }
            }
            return pattern;
        }
    }
}

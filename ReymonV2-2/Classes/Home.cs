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
            var myFlag = 1001;
            
            while(myFlag == 1001)
            {

                // data1 
                Console.Write("enter first String: ");
                var userData1 = Console.ReadLine();

                // exit
                if (userData1 == "0" || userData1 == "exit")
                    break;

                // data2
                Console.Write("enter secend String: ");
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
        public static string FindPatterns(string data )
        {
            var pattern = "";

            for(int i = 0; i < data.Length; ++i)
            {
                for (int j = 0; j < data.Length - 1 ; j++)
                {
                    if (data[j] == data[j + 1])
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

    public struct MeesageData
    {
        public int ErrorId { get; set; }
        public int SuccessId { get; set; }
        public string Message { get; set; }
    }
}

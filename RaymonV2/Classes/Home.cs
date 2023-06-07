using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RaymonV2.Classes
{
    public class Home
    {
        public int myFlag = 1001 ;
        public static void Main()
        {
            var myFlag = 1001;

            while( myFlag == 1001)
            {
                Console.Write("Enter Number [EXIT-0]: ");
                var indexOfArrey = Console.ReadLine();

                var message = HelperHome.ValidateIndexOfArrey(indexOfArrey);
                if(message.ErrorId < 0)
                {
                    Console.WriteLine(message.Message);

                    // Exit
                    if (message.ErrorId == -500)
                        myFlag = -1001;
                }
                else
                {
                    int index = Convert.ToInt32(indexOfArrey);
                    string[] names = new string[index] ;
                    HelperHome.GetNames(names, index);

                    HelperHome.ShowName(names);
                }
            }
        }
    }

    public class HelperHome
    {
        public static MessageData ValidateIndexOfArrey( string userInput )
        {
            var messageData = new MessageData();

            if (!Regex.Match(userInput, "^[0-9]*$").Success)
            {
                messageData.ErrorId = -100;
                messageData.Message = "The format is not correct";

                return messageData;
            }
            if (userInput == null || userInput == "")
            {
                messageData.ErrorId = -120;
                messageData.Message = "Data not found";

                return messageData;
            }
            if(userInput == "0")
            {
                messageData.ErrorId = -500;
                messageData.Message = "Bye";
                return messageData;
            }
            int myNumber = Convert.ToInt32(userInput);
            if (myNumber > 15 || myNumber < 0)
            {
                messageData.ErrorId = -200;
                messageData.Message = "Less than 15";

                return messageData;
            }

            messageData.SusscessId = 100;
            messageData.Message = "Done";
            return messageData;
        }
        public static void GetNames(string[] names , int index)
        {
            for(int i = 0 ; i < index ; i++)
            {
                Console.Write("Enter NAME: ");
                string data = Console.ReadLine();

                names[i] = data;
            }
        }
        public static void ShowName(string[] names)
        {
            Console.WriteLine("* * * * * * *");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("* * * * * * *");
        }
    }
    public struct MessageData
    {
        public int ErrorId { get; set; }
        public int SusscessId { get; set; }
        public string Message { get; set; }
    }

}

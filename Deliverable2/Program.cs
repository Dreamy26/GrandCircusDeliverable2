using System;

namespace Deliverable2
{
    class MainClass
    {
        private static char checksum;

        public static void Main(string[] args)
        {
            string input = "";
            string message = "";
            int checkSum = 0;

           
            {
                {


                    Console.WriteLine("So you want to send a coded message, type your message?");
                    input = Console.ReadLine().ToUpper();
                    Console.WriteLine(input);


                    foreach (char letter in input)
                    {
                        string messageLetter = (letter - 64).ToString();
                       
                        message += messageLetter + "-";
                       
                        checkSum = checkSum + letter;
                    }

                    string value = $"Your Message checkSum is {checkSum}";
                    Console.WriteLine(value);
                    Console.WriteLine($"Your Encoded message is {message}");
                    Console.ReadLine();
                }
            }


        }
    }
}

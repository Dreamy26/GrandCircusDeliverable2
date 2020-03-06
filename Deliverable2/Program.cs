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


                    Console.WriteLine("So you want to send a coded message?");
                    input = Console.ReadLine().ToUpper();


                    foreach (char letter in input)
                    {
                        string messageLetter = (letter - 64).ToString();
                       
                        message += messageLetter + "-";
                       
                        checksum = checksum + letter;
                    }

                    string value = $"Your Message checksum is {checksum}";
                    Console.WriteLine(value);
                    Console.WriteLine($"Your Encoded message is {message}");
                    Console.ReadLine();
                }
            }


        }
    }
}

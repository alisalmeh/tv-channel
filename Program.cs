using System;

namespace AliSalmeh_ProjectWeek5_TVChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            int channel = 0;
            bool isLoved = false;
            string userAnswer;

            do
            {
                PrintChannelInfo(++channel);
                userAnswer = GetUserInput();
                isLoved = userAnswer == "yes";

            } while (!isLoved);

            Console.WriteLine($"Enjoy watching channel {channel} ");
            Console.WriteLine("^__^");
        }

        public static string GetUserInput()
        {
            return Console.ReadLine().ToLower();
        }

        public static void PrintChannelInfo(int channelNumber)
        {
            Console.Clear();
            Console.WriteLine($"**Channel {channelNumber}**");
            Console.WriteLine("Do you love this channel? (yes/no)");
        }
    }
}
using System;

namespace AliSalmeh_ProjectWeek5_TVChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool nextChannel = false;
            do
            {
                Console.Clear();
                Console.WriteLine($"**Channel {++i}**");
                Console.WriteLine("Do you like this Channel? (yes/no)");
                string userAns = Console.ReadLine().ToLower();

                nextChannel = userAns == "yes" ? true : false;

            } while (nextChannel == false);

            Console.WriteLine($"Enjoy watching channel {i} ");
            Console.WriteLine("^__^");

            /* string userAnswer = null;
            int channel = 0;
            while (userAnswer != "yes")
            {
                Console.WriteLine($"DO you love channel {++channel}?");
                userAnswer = Console.ReadLine();
            } */
        }
    }
}
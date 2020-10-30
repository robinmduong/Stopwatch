using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'start' to start the stopwatch.");
            var stopWatch = new Stopwatch();
            var startTime = DateTime.Now;
            var response = Console.ReadLine().ToLower();
            var prevResponse = "";
            while (!String.IsNullOrEmpty(response))
            {
                while (response != prevResponse) //don't call start or stop twice
                {

                    if (prevResponse != "start"  && response == "start")
                    {
                        prevResponse = "start";
                        startTime = stopWatch.Start();
                        Console.WriteLine("The timer has started. When you're ready to stop, enter 'stop'.");
                        response = Console.ReadLine().ToLower();
                    }

                    if (response == "stop")
                    {
                        stopWatch.Stop();
                        prevResponse = "stop";
                        var elapsedTime = DateTime.Now - startTime;
                        Console.WriteLine($"Your elapsed time is: {elapsedTime.TotalSeconds} seconds.");
                        Console.WriteLine("Ready to start a new stopwatch? Enter 'start' to start a new stopwatch.");
                        response = Console.ReadLine().ToLower();
                    }

                    if (response == prevResponse)
                    {
                        Console.WriteLine(response);
                        Console.WriteLine(prevResponse);
                        Console.WriteLine("You can't call the same command two times in a row.");
                        response = Console.ReadLine().ToLower();
                    }

                    if (response.ToLower() != "start" && response.ToLower() != "stop")
                    {
                        Console.WriteLine($"You entered a response of '{response}'. Invalid response, please try again");
                        response = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}

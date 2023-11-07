using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB07.EinfuehrungsBeispiel
{
    public static class LogView
    {

        public static void PrintReadAllLogs()
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Console.WriteLine("\nStart ReadAllLogs");
            var lineCount = ReadAllLogs();
            Console.WriteLine("Number of lines: " + lineCount);
            Console.WriteLine("Time elapsed: {0:0.0000}", stopWatch.ElapsedMilliseconds / 1000.0);

            // *** List<> in CountUniqueIPs
            stopWatch.Restart();
            Console.WriteLine("\nStart CountUniqueIPs with List");
            var ipCount = CountUniqueIPs(new List<string>());
            Console.WriteLine("Number of unique IPs: " + ipCount);
            Console.WriteLine("Time elapsed: {0:0.0000}", stopWatch.ElapsedMilliseconds / 1000.0);

            // *** HashSet<> in CountUniqueIPs
            stopWatch.Restart();
            Console.WriteLine("\nStart CountUniqueIPs with HashSet");
            var ipCount2 = CountUniqueIPs(new HashSet<string>());
            Console.WriteLine("Number of unique IPs: " + ipCount2);
            Console.WriteLine("Time elapsed: {0:0.0000}", stopWatch.ElapsedMilliseconds / 1000.0);

            Console.ReadLine();
        }

        private static int ReadAllLogs()
        {
            var logReader = new LogReader();
            var linesSeen = 0;
            foreach (var line in logReader)
            {
                var ip = line.GetIP();
                linesSeen++;
            }
            return linesSeen;
        }



        private static int CountUniqueIPs(ICollection<string> ipsSeen)
        {
            var logReader = new LogReader();
            foreach (var logLine in logReader)
            {
                var ip = logLine.GetIP();
                if (!ipsSeen.Contains(ip))
                    ipsSeen.Add(ip);
            }
            return ipsSeen.Count;
        }
    }
}

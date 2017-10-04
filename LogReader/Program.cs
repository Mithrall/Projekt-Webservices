using System;
using System.IO;
using System.Text;
using System.Threading;
using LogReader.LogServiceRef;

namespace LogReader {
    internal class Program {
        LogServiceClient client = new LogServiceClient();
        static void Main() {
            Program run = new Program();
            run.Run();
        }

        private void Run() {
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1252");

            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\logfil.txt";
            var text = File.ReadAllLines(savePath, Encoding.GetEncoding("Windows-1252"));

            foreach (var l in text) {
                var line = l.Replace('†', 'å').Replace('›', 'ø').Replace('‘', 'æ');
                Console.WriteLine(line);
                client.LogFil(line);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Press 'any' key to exit...");
            Console.ReadKey();
        }

    }
}

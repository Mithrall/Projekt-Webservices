using System;
using System.IO;
using System.Threading;
using LogReader.LogServiceRef;

namespace LogReader {
    class Program {
        LogServiceClient client = new LogServiceClient();
        static void Main() {

            Program run = new Program();
            run.Run();
        }

        private void Run() {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\logfil.txt";
            var text = File.ReadAllLines(savePath);

            foreach (var line in text) {
                Console.WriteLine(line);
                client.LogFil(line);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Press 'any' key to exit...");
            Console.ReadKey();
        }
        
    }
}

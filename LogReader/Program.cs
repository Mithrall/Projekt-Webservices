using System;
using System.IO;
using System.Threading;

namespace LogReader {
    class Program {
        static void Main(string[] args) {

            Program Run = new Program();
            Run.Run();
        }

        private void Run() {
            string SavePath = "C:\\Users\\Kenneth\\Desktop\\logfil.txt";
            var text = File.ReadAllLines(SavePath);

            foreach (var line in text) {
                Console.WriteLine(line);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Press 'any' key to exit...");
            Console.ReadKey();
        }
    }
}

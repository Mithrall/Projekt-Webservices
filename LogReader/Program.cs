using System;
using System.IO;
using System.Threading;
using LogReader.LogServiceRef;

namespace LogReader
{
    class Program
    {
        LogServiceClient client = new LogServiceClient();
        static void Main(string[] args)
        {
            
            Program Run = new Program();
            Run.Run();

        }

        private void Run()
        {
            //string SavePath = "C:\\Users\\Kenneth\\Desktop\\logfil.txt";
            string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\logfil.txt";
            var text = File.ReadAllLines(SavePath);
            client.Input("test");
            foreach (var line in text)
            {
                Console.WriteLine(line);
                //Thread.Sleep(1000);
                //client.Input(line);
            }

            Console.WriteLine("Press 'any' key to exit...");
            Console.ReadKey();
        }

        

        
    }
}

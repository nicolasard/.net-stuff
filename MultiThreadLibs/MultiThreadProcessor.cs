using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class MultiThreadProcessor
    {
        public void runTest()
        {
            // Example using Parallel at .net
            String[] files = { "HELLO", "WORLD" };
            String finalstring = "";

            Parallel.ForEach(files, (currentFile) =>
            {

                if (currentFile.Equals("HELLO"))
                {
                    Thread.Sleep(2000);
                    finalstring = finalstring + " " + currentFile;
                }

                if (currentFile.Equals("WORLD"))
                {
                    Thread.Sleep(1000);
                    finalstring = finalstring + " " + currentFile;
                }

                Console.WriteLine("Processing {0} on thread {1}", currentFile, Thread.CurrentThread.ManagedThreadId);
            });

            Console.WriteLine("FinalString:" + finalstring);
            Console.WriteLine("Processing complete. ");
        }
    }
}

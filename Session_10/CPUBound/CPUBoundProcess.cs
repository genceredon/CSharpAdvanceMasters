using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.CPUBound
{
    public class CPUBoundProcess
    {
        public async Task ExecuteCPUBound()
        {
            Console.WriteLine("Executing CPU Bound Method");
            var stopWatch = new Stopwatch();
            //stopWatch.Start();
            ConsumeTime("Non-awaited :");
            PrintAll("Non-awaited :");
            //await Task.Run(new Action(PrintAll));

            //await Task.Run(new Action(PrintAll));
            //await Task.Run(new Action(ConsumeTime));
            //stopWatch.Stop();
            //Console.WriteLine("End Execution Time Without await: " + stopWatch.Elapsed);

            //Console.WriteLine("Start Async ");
            //stopWatch.Start();

            await Task.Run(() => PrintAll("Awaited :"));
            await Task.Run(() => ConsumeTime("Awaited :"));
            //stopWatch.Stop();
            //Console.WriteLine("Execution Time With await: " + stopWatch.Elapsed);


        }

        public void ConsumeTime(string label)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = 0;
            for(int i = 0; i < 1000; i++)
            {
                result += i;
               
            }
            stopWatch.Stop();
            Console.WriteLine($"End Execution Time for ConsumeTime() {label}"  + stopWatch.Elapsed);
            Console.WriteLine("Result of Consuming Time : " + result);
        }

        public void PrintAll(string label)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = 0;
            for (int i = 0; i < 10000; i++)
            {
                result += i;
            }
            stopWatch.Stop();

            Console.WriteLine($"End Execution Time for PrintAll() {label}" + stopWatch.Elapsed);
            Console.WriteLine("Printing times :" + result);
        }
    }
}

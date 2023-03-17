using Session_10.CPUBound;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Session_10.Methods
{

    public class WhenAllvsWaitAllProcess
    {
        private CancellationTokenSource cancellationTokenSource;
        public async Task ExecuteWhenAllvsWaitAllProcess()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // WaitAll
            Task.WaitAll(new Task[] { RangeWordAsync(), LoopSumAsync(cancellationTokenSource.Token), Task.Run(() => Console.WriteLine("Test 1")) });

            //WhenAll
            //await Task.WhenAll(RangeWordAsync(), LoopSumAsync(), Task.Run(() => Console.WriteLine("Test 1")));

            stopwatch.Stop();
            Console.WriteLine("Time elapsed when both complete..." + stopwatch.Elapsed);

        }

        private async Task<string> RangeWordAsync()
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Cancel();

            var word = string.Empty;


            foreach (var counter in Enumerable.Range(65, 26))
            {
                word = string.Concat(word, (char)counter);
                await Task.Delay(100);
            }
            Console.WriteLine("RangeWordAsync Done");
            return word;
        }

        private static async Task<int> LoopSumAsync(CancellationToken token = default)
        {
            int sum = 0;

            if(token.IsCancellationRequested)
            {
                Console.WriteLine("LoopSumAsync token status is cancelled : " + token.IsCancellationRequested.ToString());
                return 0;
            }

            foreach (var counter in Enumerable.Range(0, 25))
            {
                sum += counter;
                await Task.Delay(100);


            }
            Console.WriteLine("LoopSumAsync Done");
            return sum;
        }



    }
}

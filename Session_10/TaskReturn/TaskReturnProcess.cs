using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.TaskReturn
{
    public class TaskReturnProcess
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task ExecuteTaskReturnProcess()
        {

            var stopWatch = new Stopwatch();
            var url = "https://google.com";

            stopWatch.Start();
            Console.WriteLine("Executing I/O Bound Method");
            var stringData = await _httpClient.GetStringAsync(url);

            await PrintURL(url).ConfigureAwait(false);
            PrintURLResponse(stringData);


            stopWatch.Stop();
            Console.WriteLine(await ExecuteTaskReturnProcessWithReturnValue());
        }

        public async Task<string> ExecuteTaskReturnProcessWithReturnValue()
        {

            var stopWatch = new Stopwatch();
            var url = "https://google.com";

            stopWatch.Start();
            Console.WriteLine("Executing I/O Bound Method");
            var stringData = await _httpClient.GetStringAsync(url);

            await PrintURL(url).ConfigureAwait(false);
            await PrintURLResponse(stringData);

            Task.WaitAll();
            stopWatch.Stop();


            return "Execution Time : " + stopWatch.Elapsed;

        }

        public async Task PrintURL(string URL)
        {
            Console.WriteLine("Passed URL :" + URL);
        }

        public async Task PrintURLResponse(string URL)
        {
            Console.WriteLine(URL);
        }

    }
}

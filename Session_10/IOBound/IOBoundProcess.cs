using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.IOBound
{
    public class IOBoundProcess
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task ExecuteIOBoundProcess()
        {

            //var stopWatch = new Stopwatch();
            var url = "https://google.com";

            //stopWatch.Start();
            Console.WriteLine("Executing I/O Bound Method");
            var stringData = await _httpClient.GetStringAsync(url);

            await PrintURL(url).ConfigureAwait(false);
            await PrintURLResponse(stringData);

            //stopWatch.Stop();
            //Console.WriteLine("Execution Time : " + stopWatch.Elapsed);

        }
        
        public async Task PrintURL(string URL)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            Console.WriteLine("Passed URL :" + URL);
            stopWatch.Stop();

            Console.WriteLine("Executed time for PrintURL:"  + stopWatch.Elapsed);
        }

        public async Task PrintURLResponse(string URL)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine(URL);

            stopWatch.Stop();

            Console.WriteLine("Executed time for Print URL Response:" + stopWatch.Elapsed);

        }

    }   
    
}
    



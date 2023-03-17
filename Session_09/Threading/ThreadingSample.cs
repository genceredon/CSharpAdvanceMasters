using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Session_09.Threading
{
    public class ThreadingSample
    {
        public ThreadingSample()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread worker = new(() => CountDown());
            worker.Start();         // Run count down timer on a new thread
            CountDown();            // Simultaneously run count down timer in the main thread


            //Thread thread1 = new(CountDown);
            //Thread thread2 = new(CountDown);

            // Passing Parameter in threads
            //Thread thread1 = new(() => CountDown("Timer #1"));
            //Thread thread2 = new(() => CountDown("Timer #2"));
            ////thread1.Name = "Timer #1";
            ////thread2.Name = "Timer #2";

            //thread1.Start();                  // Sub Thread 1
            //thread2.Start();                  // Sub Thread 2
            //CountDown("Thread # Main");       // Main Thread

            //thread1.Start();
            //thread1.Join();                   // await the thread 1
            //Thread.Sleep(1000);               // sleeps the main thread for 1 second

            //Console.WriteLine($"{mainThread.Name} is complete");

            //new Thread(() => CountDown("Thread #1")).Start();


            // Sharing threads
            //NonDeterministicResult();
            //SharedState();


            // Foreground and Background Threads
            //ForeGroundThreadSample();
            //BackGroundThreadSample();

        }

        public void NonDeterministicResult()
        {
            for (int i = 0; i < 10; i++) { 
                new Thread(() => Console.Write(i)).Start();
            }
        }


        public void ForeGroundThreadSample()
        {
            Thread foregroundThread = new(() => CountDownTimer("Foreground Timer #1"));
            foregroundThread.Name = "foregroundThread";

            foregroundThread.Start();
        }

        public void BackGroundThreadSample()
        {
            // Creating and initializing thread
            Thread backgroundThread = new(() => CountDownTimer("Background Timer #2"));

            // Name of tht thread
            backgroundThread.Name = "backgroundThread";
            
            // IsBackground is the property of Thread
            // which allows thread to run in the background
            backgroundThread.IsBackground = true;

            backgroundThread.Start();
        }

        public void SharedState()
        {
            string text = "t1";
            Thread t1 = new Thread(() => Console.WriteLine(text));

            text = "t2";
            Thread t2 = new Thread(() => Console.WriteLine(text));

            t1.Start(); // output "t2"
            t2.Start(); // output "t2"
        }

        public void CountDownTimer(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{name} : {i} seconds");
                //Thread.Sleep(1000);
            }
        }

        public void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Thread : {i} seconds");
                Thread.Sleep(1000);
            }
        }


    }
}

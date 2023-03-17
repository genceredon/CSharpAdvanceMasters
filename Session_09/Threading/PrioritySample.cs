using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09.Threading
{
    public class PrioritySample
    {
        public PrioritySample()
        {
            Priority();
        }

        public void Priority()
        {
            Thread thread1 = new Thread(() => CountDownTimer("Thread #1"));
            thread1.Name = "Thread one";
            thread1.Priority = ThreadPriority.Normal;

            Thread thread2 = new Thread(() => CountDownTimer("Thread #2"));
            thread2.Name = "Thread two";
            thread2.Priority = ThreadPriority.AboveNormal;

            Thread thread3 = new Thread(() => CountDownTimer("Thread #3"));
            thread3.Name = "Thread three";
            thread3.Priority = ThreadPriority.BelowNormal;

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        public void CountDownTimer(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Thread {name} : {i} seconds");
                Thread.Sleep(1000);
            }
        }
    }
}

using Session_10.CPUBound;
using Session_10.IOBound;
using Session_10.Methods;
using Session_10.TaskReturn;
using System;

namespace Session_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IOBoundProcess iOBoundRequest = new IOBoundProcess();
            //iOBoundRequest.ExecuteIOBoundProcess().Wait();

            ////CPUBoundProcess cpuBound = new CPUBoundProcess();
            ////cpuBound.ExecuteCPUBound().Wait();

            ////TaskReturnProcess taskReturnProcess = new TaskReturnProcess();
            ////taskReturnProcess.ExecuteTaskReturnProcess().Wait();

            WhenAllvsWaitAllProcess taskReturnProcess = new WhenAllvsWaitAllProcess();
            taskReturnProcess.ExecuteWhenAllvsWaitAllProcess().Wait();

        }


    }
}
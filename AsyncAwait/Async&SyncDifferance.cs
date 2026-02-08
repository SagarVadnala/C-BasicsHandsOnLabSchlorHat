using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Async_SyncDifferance
    {


        public static int MyMethod(int Count)
        {
            int result = 0;
            for (int i = 0; i < Count; i++)
            {
                Thread.Sleep(200); // this line is to print the OP line by line so that we can represent sync method
                Console.WriteLine($"Sync Num Print : {i}");
                result += i;
            }
            return result;
        }
        public static Task<int> MyMethodASync(int Count)
        {
            Task<int> task = new Task<int>(() => // inline function 
            {// wrap the same code as above
                Console.WriteLine("Start of MyMethodAsync");
                int result = 0;
                for (int i = 0; i < Count; i++)
                {
                    Thread.Sleep(200); // this line is to print the OP line by line so that we can represent sync method
                    Console.WriteLine($"ASync Num Print : {i}");
                    result += i;
                }
                return result;
            });

            task.Start(); // start the task
            return task;  // return the task to the caller not int  so the out put in main method will be result2.Result.
        }
    }
}

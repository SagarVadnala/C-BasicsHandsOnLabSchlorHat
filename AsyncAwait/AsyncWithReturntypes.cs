using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncWithReturntypes
    {
        // Task base return type
        public static Task MethodAsync1(int count)
        {
            Task task = new Task(() =>
             {
                 for (int i = 1; i <= count; i++)
                 {
                     Thread.Sleep(200);
                     string message = $"Async number: {i}";
                    // Console.WriteLine(message);
                     PrintAsync(message); // replaced with CW

                     // THROW EXCEPTION OUTOFRANGE
                     // throw new IndexOutOfRangeException("Index out of range ");
                 }
             });
            task.Start();
            return task; 

        }

        // return integer typer
        public static Task<int> MethodAsync2(int count) 
        {
            int result = 0;
            Task<int> task = new Task<int>(() =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Thread.Sleep(200);
                    string message = $"Async number: {i}";
                    // Console.WriteLine(message);
                    PrintAsync(message); // replaced with CW
                    result += i;
                    
                }
                return result;
            });
            task.Start();
            return task;

        }

        // RETURN TYPE VOID
        private static void PrintAsync(string message)
        {
            Task task = new Task(() =>
            {
                
                Console.WriteLine(message);
            });
            task.Start();
        }
    }
}

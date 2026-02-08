namespace AsyncAwait
{
    public class Program
    {
        /*
         OP
          __ASync method call
         __Sync method call
         Start of MyMethodAsync
         Sync Num Print : 0
         ASync Num Print : 0
         ASync Num Print : 1
         Sync Num Print : 1
         Sync Num Print : 2
         ASync Num Print : 2
         Sync Num Print : 3
         ASync Num Print : 3
         Sync Num Print : 4
         Sync method result: 10
         ASync Num Print : 4
         ASync method result: 10

             You can see that MyMethodASync is not waiting for the completion of MyMethod and it is executing in parallel with MyMethod.
        its because we are using Async Method to run MyMethodASync and Task runs on a separate thread and it is not blocking the main thread.
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("__ASync method call");
            var result2 = MyMethodASync(5); // method will get called and then simulteniously  MyMethod will get called and both will run in parallel and
                                            // we will get the result of both method at the end of the main method.

            Console.WriteLine("__Sync method call");
            var result1 = MyMethod(5); // as its a Sync method the below CW lined are not getting executed until the completion of this method or line

         
            Console.WriteLine($"Sync method result: {result1} ");
            Console.WriteLine($"ASync method result: {result2.Result} ");
        }

        private static int MyMethod(int Count)
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
        private static Task<int> MyMethodASync(int Count)
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

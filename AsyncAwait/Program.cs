using System.Threading.Tasks;

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
        static async Task Main(string[] args)
        {
            //UnComment below lines for Async_SyncDifferance
            /*
            Console.WriteLine("__ASync method call");
            var result2 = Async_SyncDifferance.MyMethodASync(5); // method will get called and then simulteniously  MyMethod will get called and both will run in parallel and
                                            // we will get the result of both method at the end of the main method.

            Console.WriteLine("__Sync method call");
            var result1 = Async_SyncDifferance.MyMethod(5); // as its a Sync method the below CW lined are not getting executed until the completion of this method or line


            Console.WriteLine($"Sync method result: {result1} ");
            Console.WriteLine($"ASync method result: {result2.Result} ");
            */

           // Console.WriteLine("AsyncWithReturntypes");

            //var result1 = AsyncWithReturntypes.MethodAsync1(5);
            
           // result1.Wait(); // Wait for the completion of the async method before proceeding to the next line
                            // with out Wait() the Async Method will not be executed and there will be no O/P
                            // Agregate exception : exception hiden with in inner exception
            
            //another style
            //result1.GetAwaiter().GetResult(); // recommended way to execution and it will aslo give us the Argument Exception: detailed explanation


            //var result2 = AsyncWithReturntypes.MethodAsync2(5);
            //result2.GetAwaiter().GetResult();
            //Console.WriteLine($"Async method int returntyper returned value: {result2.Result} ");


            //async Methods with Await key word
            Console.WriteLine("To execute  AsyncAwaitSample with API");

            AsyncAwaitSample sample = new AsyncAwaitSample();
          //  var task = sample.GetDataAsync();   // Synchronous call to the method not recommended
            var task = await sample.GetDataAsync(); // Await keyword is used to avoid .result in CW below
                                // if we remove Await we need to provide .result in CW
                                // Note All ways use the await keyword
             Console.WriteLine(task); 
        }
         

    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    //https://jsonplaceholder.typicode.com/todos
    public class AsyncAwaitSample
    {
        public async Task<string> GetDataAsync()
        {
            HttpClient client = new HttpClient();
            Uri apiAddres = new Uri("https://jsonplaceholder.typicode.com/todos");
            var task1 = await client.GetAsync(apiAddres);
            if (task1.IsSuccessStatusCode)
            {
                var data = await task1.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                return "Error in fetching data";
            }
        }
    }

        
}

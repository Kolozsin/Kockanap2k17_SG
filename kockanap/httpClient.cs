using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace kockanap
{
    class httpCliens
    {
        static HttpClient client = new HttpClient();


        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://192.168.1.120:194/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Console.ReadLine();

        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClienteUno_Api
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );

            HttpResponseMessage response = client.GetAsync("http://localhost:4396/api/Presenta/4").Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Todo ok!");
                var r = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(r);
            }
            else {
                Console.WriteLine("{0} ({1})",(int)response.StatusCode,response.ReasonPhrase);
            }

            Console.ReadKey();
        }
    }
}

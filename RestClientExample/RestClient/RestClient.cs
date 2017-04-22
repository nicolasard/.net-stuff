using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RestClientExample
{
    class RestClient
    {
        static String UserAgent = ".NET Simple Rest Client";

        public static async Task queryAsync(String uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent",RestClient.UserAgent );

            var stringTask = client.GetStringAsync(uri);

            var msg = await stringTask;
            Console.Write(msg);
        }

        public static String query(String uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", RestClient.UserAgent);

            var stringTask = client.GetStringAsync(uri).Result;

            return stringTask;
        }
    }
}

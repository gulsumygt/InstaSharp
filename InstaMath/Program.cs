using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace InstaMath
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetStringAsync("https://api.instagram.com/v1/tags/search?access_token=1479869143.1fb234f.ff90752786554abbaa322a41c026f863&q=car");
                response.Wait();

                var responseBody = response.Result;
            }
        }
    }
}

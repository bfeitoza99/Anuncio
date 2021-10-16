using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Domain.HttpClientInstance
{
    public class HttpClientInstance
    {
        private HttpClientInstance()
        {

        }
        public static HttpClient GetHttpClientInstance()
        {
            HttpClient httpClient = new HttpClient();
            return httpClient;
        }
    }
}

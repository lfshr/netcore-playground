using System;
using System.Net.Http;
using pact_domain;

namespace pact_web
{
    public class SomethingApiClient 
    {
        public Something GetSomething()
        {
            var baseuri = new Uri("https://localhost:5050");

            using (var client = new HttpClient{ BaseAddress = baseuri })
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "/api/something");
                request.Headers.Add("Accept", "application/json");

                var response = client.SendAsync(request);
            }

            return new Something(){ID = 1, Message="Hello World"};
        }
    }
}
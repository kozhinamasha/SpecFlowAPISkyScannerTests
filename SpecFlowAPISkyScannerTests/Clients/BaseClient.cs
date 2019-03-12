using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SpecFlowApiSkyScannerTests.Infrastucture
{
    public abstract class BaseClient
    {
        private readonly HttpClient _client;
        protected BaseClient(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "f20d0b7e55msh2047cf956987107p131b5djsn1942515639c5");
        }

        protected HttpResponseMessage Get(string url)
        {
            Console.WriteLine("Get request: {0} \n", _client.BaseAddress + url);
            HttpResponseMessage result = _client.GetAsync(_client.BaseAddress + url).Result;
            Console.WriteLine("Response body: {0}", result.Content.ReadAsStringAsync().Result);
            return result;
        }
       
        protected HttpResponseMessage Post(string url,object body)
        {
            Console.WriteLine("Post request: {0}", _client.BaseAddress + url);
            Console.WriteLine("Send body: {0}", body);
            HttpResponseMessage result = _client.PostAsJsonAsync(_client.BaseAddress, body).Result;
            Console.WriteLine("Response body: {0}", result.Content.ReadAsStringAsync().Result);
            return result;
        }

        protected HttpResponseMessage Put(string url, object body)
        {
            Console.WriteLine("Put request: {0}", _client.BaseAddress + url);
            HttpResponseMessage result = _client.PutAsJsonAsync(_client.BaseAddress + url, body).Result;
            Console.WriteLine("Response body: {0}", result.Content.ReadAsStringAsync().Result);
            return result;
        }

        protected HttpResponseMessage Delete(string url)
        {
            Console.WriteLine("Delete request: {0}",_client.BaseAddress + url);
            HttpResponseMessage result = _client.DeleteAsync(_client.BaseAddress + url).Result;
            Console.WriteLine("Response body: {0}", result.Content.ReadAsStringAsync().Result);
            return result;
            
        }
    }
}

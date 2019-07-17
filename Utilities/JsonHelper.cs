using EquityStudioAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EquityStudioAPI.Utilities
{
    public static partial class Helpers
    {
        public static async Task<T> GetJson<T>(string url, string apiVendor, IHttpClientFactory clientFactory, JsonSerializerSettings serializerSettings = null) where T : new()
        {
            using (var client = clientFactory.CreateClient(apiVendor))
            using (var response = await client.GetAsync(url))
            {
                
                var json_data = await response.Content.ReadAsStringAsync();

                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data, serializerSettings) : new T();
            }
        } 
        
        public class ApiException  : Exception
        {

        }
    }
}

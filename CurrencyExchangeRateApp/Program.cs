using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRateApp
{
   
    public class CuurrencyExchangeRate
    {

        static async Task Main()
        {
            Root cuurrencyExchangerateObj = null;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/aud.json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            cuurrencyExchangerateObj = JsonConvert.DeserializeObject<Root>(responseBody);

        }
    }
}

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScryfallCardGenerator.Tools
{
    public class ScryfallClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<CardInfo> GetRandomCardAsync()
        {
            string url = "https://api.scryfall.com/cards/random";

            // Create the request and add necessary headers
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Accept", "application/json"); // Explicitly ask for JSON
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "YourAppName/1.0 (your@email.com)"); // Mimic a real browser request

            // Send the request
            HttpResponseMessage response = await _httpClient.SendAsync(request);

            // Check if response is successful
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CardInfo>(jsonResponse);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine("Card not found.");
                return null;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error details: {errorResponse}");
                return null;
            }
        }
    }
}

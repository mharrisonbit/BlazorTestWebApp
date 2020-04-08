using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorTestWeb.Helpers;
using BlazorTestWeb.Interfaces;

namespace BlazorTestWeb.RestCalls
{
    public class RestService : IRestService
    {
        private HttpClient Client;

        public async Task<string> GetAllUpcomingEvents()
        {
            var eventString = "";
            try
            {
                Client = new HttpClient();
                Uri uri = new Uri($"{Constants.BaseUrl}{Constants.CityName}/api/{Constants.Events}?_format=json");

                var response = await Client.GetAsync(uri);
                eventString = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"                RestService:GetAllUpcomingEvents {ex.Message}");
            }
            return eventString;
        }

        public async Task<string> GetAllFeeds()
        {
            var feedsString = "";

            try
            {
                Client = new HttpClient();
                Uri uri = new Uri($"{Constants.BaseUrl}{Constants.CityName}/api/{Constants.Feeds}?_format=json");

                var response = await Client.GetAsync(uri);
                feedsString = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"                RestService:GetAllFeeds {ex.Message}");
            }

            return feedsString;
        }
    }
}

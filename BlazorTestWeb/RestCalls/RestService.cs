using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorTestWeb.Helpers;
using BlazorTestWeb.Interfaces;

namespace BlazorTestWeb.RestCalls
{
    public class RestService : IRestService
    {

        public async Task<string> GetAllUpcomingEvents()
        {
            var eventString = "";
            try
            {
                var Client = new HttpClient();
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

            var data = "";
            try
            {
                var _client = new HttpClient();

                HttpResponseMessage response = null;
                Uri uri = new Uri($"{Constants.BaseUrl}{Constants.CityName}/api/feeds");

                _client.DefaultRequestHeaders.Add("Accept", "application/json");
                response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                }

                response.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!                   RestService:GetAllFeeds " + ex.Message);
            }

            return data;
        }

        public async Task<string> GetEventById(string id)
        {
            var data = "";
            try
            {
                var _client = new HttpClient();

                HttpResponseMessage response = null;
                Uri uri = new Uri($"{Constants.BaseUrl}{Constants.CityName}/api/event/{id}?_format=json");

                _client.DefaultRequestHeaders.Add("Accept", "application/json");
                response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                }

                response.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!                   GetDataAsync:GetEventById " + ex.Message);
            }

            return data;
        }

        public async Task<string> GetAllRestaraunts()
        {
            var data = "";
            try
            {
                var _client = new HttpClient();

                HttpResponseMessage response = null;
                Uri uri = new Uri($"{Constants.BaseUrl}{Constants.CityName}/api/restaraunts?_format=json");

                _client.DefaultRequestHeaders.Add("Accept", "application/json");
                response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                }

                response.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!                   GetDataAsync:GetAllRestaraunts " + ex.Message);
            }

            return data;
        }

        public async Task<string> GetrestarauntsById(string id)
        {
            var data = "";
            try
            {
                var _clientOne = new HttpClient();

                HttpResponseMessage response = null;
                Uri uri = new Uri($"{Constants.BaseUrl}{Constants.CityName}/api/restaurant/{id}?_format=json");

                _clientOne.DefaultRequestHeaders.Add("Accept", "application/json");
                response = await _clientOne.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                }

                response.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!                   GetDataAsync:GetAllRestaraunts " + ex.Message);
            }

            return data;
        }
    }
}

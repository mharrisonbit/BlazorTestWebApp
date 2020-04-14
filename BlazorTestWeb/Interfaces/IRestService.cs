using System;
using System.Threading.Tasks;

namespace BlazorTestWeb.Interfaces
{
    public interface IRestService
    {
        Task<string> GetAllFeeds();
        Task<string> GetAllRestaraunts();
        Task<string> GetAllShops();
        Task<string> GetAllUpcomingEvents();
        Task<string> GetEventById(string id);
        Task<string> GetrestarauntsById(string id);
        Task<string> GetShopById(string id);
    }
}

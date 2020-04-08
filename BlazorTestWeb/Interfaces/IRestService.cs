using System;
using System.Threading.Tasks;

namespace BlazorTestWeb.Interfaces
{
    public interface IRestService
    {
        Task<string> GetAllFeeds();
        Task<string> GetAllUpcomingEvents();
    }
}

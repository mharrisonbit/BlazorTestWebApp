using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Events
{
    public partial class UpComingEvents
    {
        public ObservableCollection<Event> UpcomingEvents { get; set; }

        [Inject]
        protected IRestService Rest { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UpcomingEvents = new ObservableCollection<Event>();
            var eventString = await this.Rest.GetAllUpcomingEvents();
            UpcomingEvents = Event.FromJson(eventString);
        }
    }
}

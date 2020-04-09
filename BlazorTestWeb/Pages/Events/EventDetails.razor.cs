using System.Linq;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Events
{
    public partial class EventDetails
    {
        [Inject]
        protected IRestService Rest { get; set; }
        [Parameter]
        public string PassedEvent { get; set; }

        public EventById EventToShow { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EventToShow = new EventById();
            var jsonString = await this.Rest.GetEventById(PassedEvent);
            var tempEventToShow = EventById.FromJson(jsonString);

            EventToShow = tempEventToShow.FirstOrDefault();
            System.Console.WriteLine(EventToShow);
        }
    }
}
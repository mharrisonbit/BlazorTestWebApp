using System.Text.Json;
using BlazorTestWeb.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Events
{
    public partial class EventDetails
    {
        [Parameter]
        public string PassedEvent { get; set; }

        public Event SelectedEvent { get; set; }

        protected override void OnInitialized()
        {
            System.Console.WriteLine(PassedEvent);
        }

        void DeserilizeDetailsString(string obj)
        {
            SelectedEvent = JsonSerializer.Deserialize<Event>(obj);
        }
    }
}
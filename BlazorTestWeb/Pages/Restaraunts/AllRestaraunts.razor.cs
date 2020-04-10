using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Restaraunts
{
    public partial class AllRestaraunts
    {
        public List<Restaraunt> RestarauntList { get; private set; }
        [Inject]
        protected IRestService Rest { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RestarauntList = new List<Restaraunt>();
            var restaurantString = await this.Rest.GetAllRestaraunts();
            RestarauntList = Restaraunt.FromJson(restaurantString);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Restaraunts
{
    public partial class RestarauntDetails
    {
        [Inject]
        public IRestService rest { get; set; }
        [Parameter]
        public string Id { get; set; }

        public RestarauntDetails()
        {
        }

        public List<RestarauntById> RestarauntByIdList { get; private set; }
        public RestarauntById SelectedRestaurant { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            RestarauntByIdList = new List<RestarauntById>();
            SelectedRestaurant = new RestarauntById();
            var restaurantString = await this.rest.GetrestarauntsById(Id);
            RestarauntByIdList = RestarauntById.FromJson(restaurantString);
            SelectedRestaurant = RestarauntByIdList.FirstOrDefault();

        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Shops
{
    public partial class AllShops
    {
        [Inject]
        public IRestService Rest { get; set; }

        public List<Shop> ShopList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ShopList = new List<Shop>();
            var shopString = await this.Rest.GetAllShops();
            ShopList = Shop.FromJson(shopString);
        }
    }
}

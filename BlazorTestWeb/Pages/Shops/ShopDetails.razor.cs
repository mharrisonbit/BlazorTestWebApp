using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Shops
{
    public partial class ShopDetails
    {
        [Parameter]
        public string Nid { get; set; }
        [Inject]
        public IRestService Rest { get; set; }

        public List<Shop> ShopList { get; set; }
        public List<ShopById> ShopByIdList { get; private set; }
        public ShopById SelectedShop { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            ShopByIdList = new List<ShopById>();
            SelectedShop= new ShopById();
            var shopString = await this.Rest.GetShopById(Nid);
            ShopByIdList = ShopById.FromJson(shopString);
            SelectedShop = ShopByIdList.FirstOrDefault();
        }
    }
}

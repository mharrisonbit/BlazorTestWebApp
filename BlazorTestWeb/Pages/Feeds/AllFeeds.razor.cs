using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTestWeb.Data;
using BlazorTestWeb.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorTestWeb.Pages.Feeds
{
    public partial class AllFeeds
    {
        [Inject]
        protected IRestService Rest{ get; set; }

        public List<Feed> FeedList { get; private set; }
        public string LoopFirstRun { get; set; }

        protected override async Task OnInitializedAsync()
        {
            FeedList = new List<Feed>();
            var feedsString = await this.Rest.GetAllFeeds();
            FeedList = Feed.FromJson(feedsString);
        }
    }
}
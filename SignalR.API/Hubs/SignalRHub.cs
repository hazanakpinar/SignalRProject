using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccess.Concrete;

namespace SignalR.API.Hubs
{
    public class SignalRHub:Hub
    {
        SignalRDbContext context = new SignalRDbContext();
        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}

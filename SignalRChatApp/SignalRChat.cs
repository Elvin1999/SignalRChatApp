using Microsoft.AspNetCore.SignalR;

namespace SignalRChatApp
{
    public class SignalRChat :Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
    }
}

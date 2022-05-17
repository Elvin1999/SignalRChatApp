using Microsoft.AspNetCore.SignalR;

namespace SignalRChatApp
{
    public class SignalRChat :Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }



        public override async Task OnConnectedAsync()
        {
            string info = " connected successfully";
            await Clients.Others.SendAsync("Connect",info);
        }

    }
}

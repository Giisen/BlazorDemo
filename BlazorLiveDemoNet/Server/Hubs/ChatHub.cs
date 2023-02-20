using BlazorLiveDemoNet.Shared.DTOs;
using Microsoft.AspNetCore.SignalR;

namespace BlazorLiveDemoNet.Server.Hubs;

public class ChatHub:Hub
{
    public async Task BroadCastMessage(ChatMessageDto message)
    {
        await Clients.All.SendAsync("BroadCastMessage", message);
    }
}
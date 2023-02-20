using BlazorLiveDemoNet.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace BlazorLiveDemoNet.Client.Pages;

partial class Chat:ComponentBase
{
    public ChatMessageDto CurrentMessage { get; set; } = new();
    public List<ChatMessageDto> Messages { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Messages = new List<ChatMessageDto>();
        await base.OnInitializedAsync();
    }

    private void SendMessage()
    {
        CurrentMessage.Timestamp = DateTime.UtcNow;
        Messages.Add(CurrentMessage);
        CurrentMessage = new ChatMessageDto();
    }
}
using Discord.WebSocket;

namespace MachinesBot.Discord.Entities
{
    class BotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}

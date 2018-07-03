using MachinesBot.Discord;
using MachinesBot.Discord.Entities;
using System;

namespace MachinesBot
{
    class Program
    {
        static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, World!");

            var discordBotConfig = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}

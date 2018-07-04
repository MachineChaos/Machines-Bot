using MachinesBot.Discord;
using MachinesBot.Discord.Entities;
using System;

namespace MachinesBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, World!");

            var discordBotConfig = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            var connection = Unity.Resolve<Connection>();

            Console.ReadKey();
        }
    }
}

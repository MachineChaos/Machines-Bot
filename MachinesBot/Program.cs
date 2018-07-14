using MachinesBot.Discord;
using MachinesBot.Discord.Entities;
using System;
using System.Threading.Tasks;

namespace MachinesBot
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, World!");

            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.ReadKey();
        }
    }
}

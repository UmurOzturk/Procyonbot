using Discord;
using Discord.Commands;
using Discord.Net;
using Discord.Logging;
using Discord.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcyonBot
{

    class MyBot
    {
        DiscordClient discord;

        public MyBot()
        {
            discord = new DiscordClient(x =>
           {
               x.LogLevel = LogSeverity.Info;
               x.LogHandler = Log;
           });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '+';
                x.AllowMentionPrefix = true;
                
            });

            var commands = discord.GetService<CommandService>();

            commands.CreateCommand("procyon")
                .Do(async (e) =>
                 {
                     await e.Channel.SendMessage("Bir Guildden Ötesi");
                 });

            commands.CreateCommand("temizle")
                .Do(async (e) =>
                {
                    Message[] messagesToDelete;
                    messagesToDelete = await e.Channel.DownloadMessages(100);
                    await e.Channel.DeleteMessages(messagesToDelete);
                });
            commands.CreateCommand("yönetim")
           .Do(async (e) =>
            {
                await e.Channel.SendMessage("General = Axheron" + Environment.NewLine + "Commander = Decapitare" + Environment.NewLine + "Officer = Whiskey" + Environment.NewLine + "Officer = Warren" + Environment.NewLine + "Officer = Luftmensch");
            });

            commands.CreateCommand("yardım")
                .Do(async (e) =>
            {
                await e.User.SendMessage("Procyon Bot Komutlarını Görüntülüyorsunuz...(komutların başına + koyunuz) " + Environment.NewLine + "Yönetim = yetkili kişileri gösterir..." + Environment.NewLine + "Procyon = guilde not bırakılmış ise onu görürsünüz..." + Environment.NewLine + "Temizle = kanalda ki yazıları temizler...");
            });

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("Mjg0MzE3MTAxNzIyOTU5ODc0.C5B8FA.NWmx8VwtHs5zOwbvG1j2pzRwfvw",TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

using Discord.Commands;
using System.Threading.Tasks;

namespace BloodyTakao.WorldTimes
{
    [Group("time")]
    public class WorldTimesModule : ModuleBase<SocketCommandContext>
    {
        [Command("get")]
        public async Task GetTimeCommandAsync(string timezone)
        {
            if (timezone == "Central Europe" || timezone == "France" || timezone == "Germany")
            {
                await ReplyAsync(DateTime.Now.ToString("hh:mm tt"));
            }
        }
    }
}
using System;
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
            TimeZoneInfo timeZone;
            DateTime time;

            switch(timezone.ToLower())
            {
                #region UTC+1
                case "central europe":
                case "france":
                case "germany":
                case "albania":
                case "andorra":
                case "austria":
                case "belgium":
                case "bosnia and herzegovina":
                case "croatia":
                case "czech republic":
                case "denmark":
                case "hungary":
                case "italy":
                case "kosovo":
                case "liechtenstein":
                case "luxembourg":
                case "north macedonia":
                case "malta":
                case "monaco":
                case "montenegro":
                case "netherlands":
                case "norway":
                case "poland":
                case "san marino":
                case "serbia":
                case "slovakia":
                case "slovenia":
                case "spain":
                case "sweden":
                case "switzerland":
                 timeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
                break;
                #endregion
                #region UTC+0
                case "portugal":
                case "united kingdom":
                case "ireland":
                case "canary islands":
                case "faroe islands":
                case "madeira islands":
                case "madeira":
                case "iceland":
                case "iss":
                case "international space station":
                 timeZone = TimeZoneInfo.FindSystemTimeZoneById("Greenwich Standard Time");
                break;
                #endregion
                #region UTC+2
                case "":
                 timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern European Time");
                break;
                #endregion



                default: timeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
                break;
            }

            time = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);
            await ReplyAsync(time.ToString("hh:mm tt"));        
        }
    }
}
using Discord.Commands;
using System.Threading.Tasks;


namespace Nodsoft.YumeChan.PluginSampleCS
{
	/* 
	 * Classes can here act as a bundle of Commands. The only limitation is one Class per Group Name.
	 * 
	 * A few Rules :
	 *	- Class MUST inherit ModuleBase to get flagged as a Module containing commands.
	 *	- Class MUST be set as public to get picked up by the Loader.
	 * 
	 * /!\ DO NOT USE THESE CLASSES TO STORE PERSISTENT DATA. /!\
	 * Each "Command Group" Class is Instantiated when a Command from its group is called. 
	 * The instance immediately vanishes after finishing command execution.
	 */
	[Group("ping")]
	public class Ping : ModuleBase<SocketCommandContext>
	{
		/*
		 * Attribute "Command" marks this method as an executable command by the Core.
		 * Optional Attribute "Alias" provides (a) different name(s) for this command.
		 * 
		 * To execute this command, assuming prefix as "==", User can type :
		 *		==ping csharp
		 * OR	==ping cs
		 * 
		 * Method MUST be set as public to get picked up by the Loader.
		 */
		[Command("csharp"), Alias("cs")]
		public async Task PingHelloCSharp()
		{
			await ReplyAsync("Hello from YumeChan's C# Sample Plugin !");
		}
	}
}

// For more info, check Discord.NET's guide on Commands : https://discord.foxbot.me/docs/guides/commands/intro.html#modules

using System;
using System.Threading.Tasks;
using Nodsoft.YumeChan.PluginBase;

namespace Nodsoft.YumeChan.PluginSampleCS
{
	// This Class defines the Plugin, and makes it visible to the Loader.
	public class PluginManifest : IPlugin // Class MUST be set as public to get picked up by the Loader.
	{
		// For Good principle, do not change a thing here, unless your Versionning has to be different from that of the Assembly.
		// Consider changing your Version within the Assembly instead.
		public Version PluginVersion => typeof(PluginManifest).Assembly.GetName().Version;

		public string PluginDisplayName { get; } = "YumeChan : Sample Plugin";

		public bool PluginStealth { get; } = false;

		// This is handled solely by the LoadPlugin() and UnloadPlugin() Methods below.
		public bool PluginLoaded { get; private set; } 

		public Task LoadPlugin()
		{
			//Here goes the Loading Logic, if some loading procedure is needed. Treat it as a Ctor.

			PluginLoaded = true;
			return Task.CompletedTask;
		}
		public Task UnloadPlugin()
		{
			//Here goes the Unloading Logic, if some unloading (e.g: Disposal) is needed. Treat it as a Dtor (~).

			PluginLoaded = false;
			return Task.CompletedTask;
		}
	}
}

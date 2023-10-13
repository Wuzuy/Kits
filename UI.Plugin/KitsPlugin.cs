using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kits.Plugin
{
    public class KitsPlugin : RocketPlugin<KitsPluginConfiguration>
    {
        public static KitsPlugin Instance { get; private set; }
        protected override void Load()
        {
            Logger.Log(Configuration.Instance.LoadMessage);
            Logger.Log($"{Name} {Assembly.GetName().Version} has been loaded!");
        }
        protected override void Unload()
        {
            Logger.Log($"{Name} {Assembly.GetName().Version} has been unloaded!");
        }
    }
}

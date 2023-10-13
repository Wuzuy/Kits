using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitsPlugin.Models;
using SDG.Unturned;

namespace Kits.Plugin
{
    public class KitsPluginConfiguration : IRocketPluginConfiguration
    {
        public string LoadMessage  { get; set; }

        public Kit[] Kits { get; set; }
        public void LoadDefaults()
        {
            LoadMessage = "This is UI Plugin!";
            Kits = new Kit[]
            {
                new Kit
                {
                    Name = "default",
                    Items = new ushort[]
                    {
                        363,
                        6,

                    }
                }
            };
        }
    }
}

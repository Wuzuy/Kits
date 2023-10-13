using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kits.Plugin.Commands
{
    public class KitsCommands : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "kit";

        public string Help => "";

        public string Syntax => "<name>";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (command.Length == 0)
            {
                UnturnedChat.Say( "Você não selecionou algum kit." );
                    return;
            }
            var kit = KitsPlugin.Instance.Configuration.Instance.Kits.FirstOrDefault(x => x.Name == command[0]);

            if (kit == null)
            {
                UnturnedChat.Say("Kit não encontrado");
                return;
            }
            UnturnedPlayer player = (UnturnedPlayer)caller;

            foreach (var item in kit.Items)
            {
                player.GiveItem(item, 1);
            }

            UnturnedChat.Say($"Você recebeu o kit {kit.Name}!");

        }
    }
}

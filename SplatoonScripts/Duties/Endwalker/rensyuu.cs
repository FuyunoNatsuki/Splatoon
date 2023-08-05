using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Game.ClientState.Statuses;
using Dalamud.Interface.Components;
using ECommons.Configuration;
using ECommons.DalamudServices;
using ECommons.GameFunctions;
using ECommons.Hooks;
using ECommons.ImGuiMethods;
using ECommons.MathHelpers;
using ECommons.Schedulers;
using ImGuiNET;
using Splatoon;
using Splatoon.SplatoonScripting;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using PluginLog = ECommons.Logging.PluginLog;

namespace SplatoonScriptsOfficial.Duties.Endwalker
{
    public class rensyuu : SplatoonScript
    {
        public override void OnCombatStart()
        {
            circle();
        }
         private void circle()
        {
            Element e = new Element(0);
            e.Enabled = true;
        }
    }
}
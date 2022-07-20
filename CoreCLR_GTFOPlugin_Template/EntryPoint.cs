using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System.Linq;

namespace TemplatePlugin
{
    [BepInPlugin("TemplatePlugin.GUID", VersionInfo.RootNamespace, VersionInfo.Version)]
    internal class EntryPoint : BasePlugin
    {
        private Harmony _Harmony;

        public override void Load()
        {
            _Harmony = new Harmony($"{VersionInfo.RootNamespace}.Harmony");
            _Harmony.PatchAll();

            Logger.Info($"Plugin has loaded with {_Harmony.GetPatchedMethods().Count()} patches!");
        }
    }
}
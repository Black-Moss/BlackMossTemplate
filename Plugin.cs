using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using MonoMod.RuntimeDetour;
using UnityEngine;

namespace ModNamespace
{
    [BepInPlugin("blackmoss.template", "BlackMossTemplate", "0.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;
        private readonly Harmony _harmony = new("blackmoss.template");
        public static Plugin Instance { get; private set; } = null!;

        public void Awake()
        {
            Logger = base.Logger;
            Instance = this;

            _harmony.PatchAll();
            Logger.LogInfo("Here's Black Moss!");
        }
    }
}
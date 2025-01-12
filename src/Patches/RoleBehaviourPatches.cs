using HarmonyLib;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Sentry.Internal.Extensions;
using AmongUs.GameOptions;

namespace MalumMenu;

[HarmonyPatch(typeof(EngineerRole), nameof(EngineerRole.FixedUpdate))]
public static class EngineerRole_FixedUpdate
{
    public static void Postfix(EngineerRole __instance){

        if(__instance.Player.AmOwner){

            MalumCheats.engineerCheats(__instance);
        }
    }
}

[HarmonyPatch(typeof(ScientistRole), nameof(ScientistRole.Update))]
public static class ScientistRole_Update
{

    public static void Postfix(ScientistRole __instance){

        if(__instance.Player.AmOwner){

            MalumCheats.scientistCheats(__instance);
        }
    }
}

[HarmonyPatch(typeof(TrackerRole), nameof(TrackerRole.FixedUpdate))]
public static class TrackerRole_FixedUpdate
{

    public static void Postfix(TrackerRole __instance){

        if(__instance.Player.AmOwner){

            MalumCheats.trackerCheats(__instance);
        }
    }
}

﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Managers;

namespace sweetkin.harmony
{
    class relic_on_start
    {
    //     [HarmonyPatch(typeof(SaveManager), "SetupRun")]
    //      class AddRelicAtStartOfRunPatch
    //      {
    //        static void Postfix(ref SaveManager __instance)
    //        {
    //           __instance.AddRelic(CustomCollectableRelicManager.GetRelicDataByID("Relic_SW_Mucus"));
    //        }
    //      }

        //card section
        /*[HarmonyPatch(typeof(SaveManager), "SetupRun")]
        class AddCardToStartingDeckPatch
        {
            static void Postfix(ref SaveManager __instance)
            {
                 var id = "Sweetkin_Card_SpiceCook";
                 __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(id));
            }
        }
        */
    }
}

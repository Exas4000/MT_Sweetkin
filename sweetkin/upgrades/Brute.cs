﻿using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.upgrades
{
    class Brute
    {
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder upgrade = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = "Brute_I",
                UpgradeDescriptionKey = "1c",
                UseUpgradeHighlightTextTags = true,
                BonusHP = 5,
                BonusDamage = 30,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnEaten,
                        DescriptionKey = "1c",
                        HideTriggerTooltip = true,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Monsters,
                                ParamCardUpgradeData = new CardUpgradeDataBuilder
                                {
                                    BonusDamage = 5,
                                    BonusHP = 5,
                                    HideUpgradeIconOnCard = false,
                                }.Build(),
                            }
                        }
                    }
                },
                StatusEffectUpgrades  = new List<StatusEffectStackData>
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 6
                     },
                },

            };
            return upgrade;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}

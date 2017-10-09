﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoETestApp
{
    public static class Jewel
    {
        public static List<Affix> PrefixesDex { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesDex { get; set; } = new List<Affix>();
        public static List<Affix> PrefixesInt { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesInt { get; set; } = new List<Affix>();
        public static List<Affix> PrefixesStr { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesStr { get; set; } = new List<Affix>();

        public static void PopulateAffixes()
        {
            PrefixesDex.Add(new Affix("Sinister", 1, 1, "", "% increased Physical Damage with Axes", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Vicious", 1, 1, "", "% increased Physical Damage with Swords", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Fierce", 1, 1, "", "% increased Physical Damage with Bows", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Savage", 1, 1, "", "% increased Physical Damage with Claws", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Lethal", 1, 1, "", "% increased Physical Damage with Daggers", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Soldier's", 1, 1, "", "% increased Physical Damage with One Handed Melee Weapons", 12, 14, 2.59));
            PrefixesDex.Add(new Affix("Champion's", 1, 1, "", "% increased Physical Damage with Two Handed Melee Weapons", 12, 14, 2.59));
            PrefixesDex.Add(new Affix("Gladiator's", 1, 1, "", "% increased Physical Weapon Damage while Dual Wielding", 12, 14, 2.59));
            PrefixesDex.Add(new Affix("Trapping", 1, 1, "", "% increased Trap Damage", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Sabotage", 1, 1, "", "% increased Mine Damage", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Flaming", 1, 1, "", "% increased Fire Damage", 14, 16, 2.07));
            PrefixesDex.Add(new Affix("Chilling", 1, 1, "", "% increased Cold Damage", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Humming", 1, 1, "", "% increased Lightning Damage", 14, 16, 2.07));
            PrefixesDex.Add(new Affix("Sharpened", 1, 1, "", "% increased Physical Damage", 14, 16, 2.59));
            PrefixesDex.Add(new Affix("Chaotic", 1, 1, "", "% increased Chaos Damage", 9, 13, 1.04));
            PrefixesDex.Add(new Affix("Cleaving", 1, 1, "", "% increased Attack Speed with Axes", 6, 8, 2.59));
            PrefixesDex.Add(new Affix("Fencing", 1, 1, "", "% increased Attack Speed with Swords", 6, 8, 2.59));
            PrefixesDex.Add(new Affix("Volleying", 1, 1, "", "% increased Attack Speed with Bows", 6, 8, 2.59));
            PrefixesDex.Add(new Affix("Ripping", 1, 1, "", "% increased Attack Speed with Claws", 6, 8, 2.59));
            PrefixesDex.Add(new Affix("Slicing", 1, 1, "", "% increased Attack Speed with Daggers", 6, 8, 2.59));
            PrefixesDex.Add(new Affix("Bandit's", 1, 1, "", "% increased Attack Speed with One Handed Melee Weapons", 4, 6, 2.59));
            PrefixesDex.Add(new Affix("Warrior's", 1, 1, "", "% increased Attack Speed with Two Handed Melee Weapons", 4, 6, 2.59));
            PrefixesDex.Add(new Affix("Harmonic", 1, 1, "", "% increased Attack Speed while Dual Wielding", 4, 6, 2.59));
            PrefixesDex.Add(new Affix("Charging", 1, 1, "", "% increased Attack Speed while holding a Shield", 4, 6, 2.59));
            PrefixesDex.Add(new Affix("Honed", 1, 1, "", "% increased Trap Throwing Speed", 6, 8, 1.3));
            PrefixesDex.Add(new Affix("Arming", 1, 1, "", "% increased Mine Laying Speed", 6, 8, 1.3));
            PrefixesDex.Add(new Affix("Flanking", 1, 1, "", "% increased Melee Physical Damage while holding a Shield", 12, 14, 2.59));
            PrefixesDex.Add(new Affix("Vivid", 1, 1, "", "% increased maximum Life", 5, 7, 1.81));
            PrefixesDex.Add(new Affix("Enlightened", 1, 1, "", "% increased maximum Mana", 6, 8, 2.59));
            PrefixesDex.Add(new Affix("Energetic", 1, 1, "", "% increased Mana Regeneration Rate", 12, 15, 1.3));
            PrefixesDex.Add(new Affix("Thirsting", 1, 1, "0.", "% of Physical Attack Damage Leeched as Mana", 2, 4, 1.3));
            PrefixesDex.Add(new Affix("Evasive", 1, 1, "", "% increased Evasion Rating", 14, 18, 2.59));
            PrefixesDex.Add(new Affix("Harming", 1, 1, "", "% increased Critical Strike Chance with One Handed Melee Weapons", 14, 18, 1.3));
            PrefixesDex.Add(new Affix("Sundering", 1, 1, "", "% increased Critical Strike Chance with Two Handed Melee Weapons", 14, 18, 1.3));
            PrefixesDex.Add(new Affix("Technical", 1, 1, "", "% increased Weapon Critical Strike Chance while Dual Wielding", 14, 18, 1.3));
            PrefixesDex.Add(new Affix("Incinerating", 1, 1, "", "% increased Critical Strike Chance with Fire Skills", 14, 18, 1.04));
            PrefixesDex.Add(new Affix("Avalanching", 1, 1, "", "% increased Critical Strike Chance with Cold Skills", 14, 18, 1.3));
            PrefixesDex.Add(new Affix("Thundering", 1, 1, "", "% increased Critical Strike Chance with Lightning Skills", 14, 18, 1.04));
            PrefixesDex.Add(new Affix("Piercing", 1, 1, "+", "% to Critical Strike Multiplier with One Handed Melee Weapons", 15, 18, 1.3));
            PrefixesDex.Add(new Affix("Rupturing", 1, 1, "+", "% to Critical Strike Multiplier with Two Handed Melee Weapons", 15, 18, 1.3));
            PrefixesDex.Add(new Affix("Puncturing", 1, 1, "+", "% to Critical Strike Multiplier while Dual Wielding", 15, 18, 1.3));
            PrefixesDex.Add(new Affix("Infernal", 1, 1, "+", "% to Critical Strike Multiplier with Fire Skills", 15, 18, 1.04));
            PrefixesDex.Add(new Affix("Arctic", 1, 1, "+", "% to Critical Strike Multiplier with Cold Skills", 15, 18, 1.3));
            PrefixesDex.Add(new Affix("Surging", 1, 1, "+", "% to Critical Strike Multiplier with Lightning Skills", 15, 18, 1.04));
            PrefixesDex.Add(new Affix("Parrying", 1, 1, "", "% additional Block Chance while Dual Wielding", 1, 1, 1.81));
            PrefixesDex.Add(new Affix("Shielding", 1, 1, "+", "% Chance to Block with Shields", 1, 1, 1.81));
            PrefixesDex.Add(new Affix("Dissipating", 1, 1, "", "% additional Chance to Block Spells while Dual Wielding", 1, 1, 1.81));
            PrefixesDex.Add(new Affix("Thwarting", 1, 1, "", "% additional Chance to Block Spells with Shields", 1, 1, 1.81));
            PrefixesDex.Add(new Affix("Shaman's", 1, 1, "", "% increased Totem Damage", 12, 16, 1.3));
            PrefixesDex.Add(new Affix("Carved", 1, 1, "", "% increased Totem Life", 8, 12, 1.3));

            SuffixesDex.Add(new Affix("of Combat", 1, 1, "", "% increased Melee Damage", 10, 12, 3.23));
            SuffixesDex.Add(new Affix("of Archery", 1, 1, "", "% increased Projectile Damage", 10, 12, 3.23));
            SuffixesDex.Add(new Affix("of Wounding", 1, 1, "", "% increased Damage", 8, 10, 2.26));
            SuffixesDex.Add(new Affix("of Entropy", 1, 1, "", "% increased Damage over Time", 10, 12, 3.23));
            SuffixesDex.Add(new Affix("of Blasting", 1, 1, "", "% increased Area Damage", 10, 12, 3.23));
            SuffixesDex.Add(new Affix("of Berserking", 1, 1, "", "% increased Attack Speed", 3, 5, 3.23));
            SuffixesDex.Add(new Affix("of Soaring", 1, 1, "", "% increased Projectile Speed", 6, 8, 3.23));
            SuffixesDex.Add(new Affix("of Zeal", 1, 1, "", "% increased Attack and Cast Speed", 2, 4, 2.26));
            SuffixesDex.Add(new Affix("of Strength", 1, 1, "+", " to Strength", 12, 16, 1.94));
            SuffixesDex.Add(new Affix("of Dexterity", 1, 1, "+", " to Dexterity", 12, 16, 3.23));
            SuffixesDex.Add(new Affix("of Intelligence", 1, 1, "+", " to Intelligence", 12, 16, 1.94));
            SuffixesDex.Add(new Affix("of Athletics", 1, 1, "+", " to Strength and Dexterity", 8, 10, 2.9));
            SuffixesDex.Add(new Affix("of Spirit", 1, 1, "+", " to Strength and Intelligence", 8, 10, 1.61));
            SuffixesDex.Add(new Affix("of Cunning", 1, 1, "+", " to Dexterity and Intelligence", 8, 10, 2.9));
            SuffixesDex.Add(new Affix("of Adaption", 1, 1, "+", " to all Attributes", 6, 8, 1.94));
            SuffixesDex.Add(new Affix("of Absorption", 1, 1, "+", " Mana gained for each Enemy hit by your Attacks", 1, 2, 3.23));
            SuffixesDex.Add(new Affix("of Raiding", 1, 1, "", "% increased Rarity of Items found", 4, 6, 0.97));
            SuffixesDex.Add(new Affix("of Precision", 1, 1, "", "% increased Accuracy Rating", 10, 14, 3.23));
            SuffixesDex.Add(new Affix("of Deadliness", 1, 1, "", "% increased Accuracy Rating", 6, 10, 0.97, "", "% increased Global Critical Strike Chance", 6, 10));
            SuffixesDex.Add(new Affix("of Menace", 1, 1, "", "% increased Global Critical Strike Chance", 8, 12, 1.61));
            SuffixesDex.Add(new Affix("of Potency", 1, 1, "+", "% to Global Critical Strike Multiplier", 9, 12, 1.61));
            SuffixesDex.Add(new Affix("of Weight", 1, 1, "", "% increased Melee Critical Strike Chance", 10, 14, 1.61));
            SuffixesDex.Add(new Affix("of the Apocalypse", 1, 1, "", "% increased Critical Strike Chance with Elemental Skills", 10, 14, 0.65));
            SuffixesDex.Add(new Affix("of Demolishing", 1, 1, "+", "% to Melee Critical Strike Multiplier", 12, 15, 1.61));
            SuffixesDex.Add(new Affix("of the Elements", 1, 1, "+", "% to Critical Strike Multiplier with Elemental Skills", 12, 15, 0.65));
            SuffixesDex.Add(new Affix("of the Dragon", 1, 1, "+", "% to Fire Resistance", 12, 15, 1.94));
            SuffixesDex.Add(new Affix("of the Beast", 1, 1, "+", "% to Cold Resistance", 12, 15, 3.23));
            SuffixesDex.Add(new Affix("of Grounding", 1, 1, "+", "% to Lightning Resistance", 12, 15, 1.94));
            SuffixesDex.Add(new Affix("of the Hearth", 1, 1, "+", "% to Fire and Cold Resistances", 10, 12, 2.9));
            SuffixesDex.Add(new Affix("of Insulation", 1, 1, "+", "% to Fire and Lightning Resistances", 10, 12, 1.61));
            SuffixesDex.Add(new Affix("of Shelter", 1, 1, "+", "% to Cold and Lightning Resistances", 10, 12, 2.9));
            SuffixesDex.Add(new Affix("of Resistance", 1, 1, "+", "% to all Elemental Resistances", 8, 10, 1.94));
            SuffixesDex.Add(new Affix("of Order", 1, 1, "+", "% to Chaos Resistance", 7, 13, 0.65));
            SuffixesDex.Add(new Affix("of Stunning", 1, 1, "", "% increased Stun Duration on Enemies", 10, 14, 1.29));
            SuffixesDex.Add(new Affix("of Recovery", 1, 1, "", "% increased Stun and Block Recovery", 10, 14, 1.29));
            SuffixesDex.Add(new Affix("of Efficiency", 1, 1, "", "% reduced Mana Cost of Skills", 3, 5, 3.23));
            SuffixesDex.Add(new Affix("of Fending", 1, 1, "", "% chance to Knock Enemies Back on hit", 4, 6, 1.61));
            SuffixesDex.Add(new Affix("of Freezing", 1, 1, "", "% chance to Freeze", 3, 5, 2.26, "", "% increased Freeze Duration on Enemies", 12, 16));
            SuffixesDex.Add(new Affix("of Shocking", 1, 1, "", "% chance to Shock", 3, 5, 1.61, "", "% increased Shock Duration on Enemies", 12, 16));
            SuffixesDex.Add(new Affix("of Burning", 1, 1, "", "% chance to Ignite", 3, 5, 1.61, "", "% increased Ignite Duration on Enemies", 6, 8));
            SuffixesDex.Add(new Affix("of Poisoning", 1, 1, "", "% chance to Poison on Hit", 3, 5, 2.26, "", "% increased Poison Duration", 6, 8));
            SuffixesDex.Add(new Affix("of Bleeding", 1, 1, "Attacks have ", "% chance to cause Bleeding", 3, 5, 1.61, "", "% increased Bleed duration", 12, 16));
            SuffixesDex.Add(new Affix("of Venom", 1, 1, "", "% increased Damage with Poison", 16, 20, 3.23));
            SuffixesDex.Add(new Affix("of Haemophilia", 1, 1, "", "% increased Damage with Bleeding", 16, 20, 1.61));
            SuffixesDex.Add(new Affix("of Combusting", 1, 1, "", "% increased Burning Damage", 16, 20, 3.23));
            SuffixesDex.Add(new Affix("of Runes", 1, 1, "Totems gain +", "% to all Elemental Resistances", 6, 10, 1.61));

            PrefixesInt.Add(new Affix("Cruel", 1, 1, "", "% increased Physical Damage with Wands", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Wizard's", 1, 1, "", "% increased Spell Damage while wielding a Staff", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Sorcerer's", 1, 1, "", "% increased Spell Damage while Dual Wielding", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Battlemage's", 1, 1, "", "% increased Spell Damage while holding a Shield", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Trapping", 1, 1, "", "% increased Trap Damage", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Sabotage", 1, 1, "", "% increased Mine Damage", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Leadership", 1, 1, "", "Minions deal 14% increased Damage", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Flaming", 1, 1, "", "% increased Fire Damage", 14, 16, 2.29));
            PrefixesInt.Add(new Affix("Chilling", 1, 1, "", "% increased Cold Damage", 14, 16, 2.29));
            PrefixesInt.Add(new Affix("Humming", 1, 1, "", "% increased Lightning Damage", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Sharpened", 1, 1, "", "% increased Physical Damage", 14, 16, 2.86));
            PrefixesInt.Add(new Affix("Chaotic", 1, 1, "", "% increased Chaos Damage", 9, 13, 1.14));
            PrefixesInt.Add(new Affix("Jinxing", 1, 1, "", "% increased Attack Speed with Wands", 6, 8, 2.86));
            PrefixesInt.Add(new Affix("Harmonic", 1, 1, "", "% increased Attack Speed while Dual Wielding", 4, 6, 2.86));
            PrefixesInt.Add(new Affix("Resonant", 1, 1, "", "% increased Cast Speed while Dual Wielding", 3, 5, 2.86));
            PrefixesInt.Add(new Affix("Charging", 1, 1, "", "% increased Attack Speed while holding a Shield", 4, 6, 2.29));
            PrefixesInt.Add(new Affix("Warding", 1, 1, "", "% increased Cast Speed while holding a Shield", 3, 5, 2.86));
            PrefixesInt.Add(new Affix("Wright's", 1, 1, "", "% increased Cast Speed while wielding a Staff", 3, 5, 2.86));
            PrefixesInt.Add(new Affix("Honed", 1, 1, "", "% increased Trap Throwing Speed", 6, 8, 1.43));
            PrefixesInt.Add(new Affix("Arming", 1, 1, "", "% increased Mine Laying Speed", 6, 8, 1.43));
            PrefixesInt.Add(new Affix("Pyromantic", 1, 1, "", "% increased Cast Speed with Fire Skills", 3, 5, 2.86));
            PrefixesInt.Add(new Affix("Cryomantic", 1, 1, "", "% increased Cast Speed with Cold Skills", 3, 5, 2.86));
            PrefixesInt.Add(new Affix("Electromantic", 1, 1, "", "% increased Cast Speed with Lightning Skills", 3, 5, 2.86));
            PrefixesInt.Add(new Affix("Vivid", 1, 1, "", "% increased maximum Life", 5, 7, 2));
            PrefixesInt.Add(new Affix("Enlightened", 1, 1, "", "% increased maximum Mana", 6, 8, 2.86));
            PrefixesInt.Add(new Affix("Energetic", 1, 1, "", "% increased Mana Regeneration Rate", 12, 15, 2.86));
            PrefixesInt.Add(new Affix("Shimmering", 1, 1, "", "% increased maximum Energy Shield", 6, 8, 2.86));
            PrefixesInt.Add(new Affix("Incinerating", 1, 1, "", "% increased Critical Strike Chance with Fire Skills", 14, 18, 1.14));
            PrefixesInt.Add(new Affix("Avalanching", 1, 1, "", "% increased Critical Strike Chance with Cold Skills", 14, 18, 1.14));
            PrefixesInt.Add(new Affix("Thundering", 1, 1, "", "% increased Critical Strike Chance with Lightning Skills", 14, 18, 1.43));
            PrefixesInt.Add(new Affix("Infernal", 1, 1, "+", "% to Critical Strike Multiplier with Fire Skills", 15, 18, 1.14));
            PrefixesInt.Add(new Affix("Arctic", 1, 1, "+", "% to Critical Strike Multiplier with Cold Skills", 15, 18, 1.14));
            PrefixesInt.Add(new Affix("Surging", 1, 1, "+", "% to Critical Strike Multiplier with Lightning Skills", 15, 18, 1.43));
            PrefixesInt.Add(new Affix("Parrying", 1, 1, "", "% additional Block Chance while Dual Wielding", 1, 1, 2));
            PrefixesInt.Add(new Affix("Shielding", 1, 1, "+", "% Chance to Block with Shields", 1, 1, 2));
            PrefixesInt.Add(new Affix("Deflecting", 1, 1, "", "% additional Chance to Block with Staves", 1, 1, 2));
            PrefixesInt.Add(new Affix("Dissipating", 1, 1, "", "% additional Chance to Block Spells while Dual Wielding", 1, 1, 2));
            PrefixesInt.Add(new Affix("Thwarting", 1, 1, "", "% additional Chance to Block Spells with Shields", 1, 1, 2));
            PrefixesInt.Add(new Affix("Halting", 1, 1, "", "% additional Chance to Block Spells with Staves", 1, 1, 2));
            PrefixesInt.Add(new Affix("Serene", 1, 1, "", "% faster start of Energy Shield Recharge", 4, 6, 2.86));
            PrefixesInt.Add(new Affix("Fevered", 1, 1, "", "% increased Energy Shield Recharge Rate", 6, 8, 2.86));
            PrefixesInt.Add(new Affix("Master's", 1, 1, "Minions have ", "% increased maximum Life", 8, 12, 2));
            PrefixesInt.Add(new Affix("Shaman's", 1, 1, "", "% increased Totem Damage", 12, 16, 1.43));
            PrefixesInt.Add(new Affix("Carved", 1, 1, "", "% increased Totem Life", 8, 12, 1.43));

            SuffixesInt.Add(new Affix("of Archery", 1, 1, "", "% increased Projectile Damage", 10, 12, 2.6));
            SuffixesInt.Add(new Affix("of Mysticism", 1, 1, "", "% increased Spell Damage", 10, 12, 3.25));
            SuffixesInt.Add(new Affix("of Wounding", 1, 1, "", "% increased Damage", 8, 10, 2.27));
            SuffixesInt.Add(new Affix("of Entropy", 1, 1, "", "% increased Damage over Time", 10, 12, 3.25));
            SuffixesInt.Add(new Affix("of Blasting", 1, 1, "", "% increased Area Damage", 10, 12, 3.25));
            SuffixesInt.Add(new Affix("of Berserking", 1, 1, "", "% increased Attack Speed", 3, 5, 3.25));
            SuffixesInt.Add(new Affix("of Soaring", 1, 1, "", "% increased Projectile Speed", 6, 8, 1.95));
            SuffixesInt.Add(new Affix("of Enchanting", 1, 1, "", "% increased Cast Speed", 2, 4, 3.25));
            SuffixesInt.Add(new Affix("of Zeal", 1, 1, "", "% increased Attack and Cast Speed", 2, 4, 2.27));
            SuffixesInt.Add(new Affix("of Strength", 1, 1, "+", " to Strength", 12, 16, 1.95));
            SuffixesInt.Add(new Affix("of Dexterity", 1, 1, "+", " to Dexterity", 12, 16, 1.95));
            SuffixesInt.Add(new Affix("of Intelligence", 1, 1, "+", " to Intelligence", 12, 16, 3.25));
            SuffixesInt.Add(new Affix("of Athletics", 1, 1, "+", " to Strength and Dexterity", 8, 10, 1.62));
            SuffixesInt.Add(new Affix("of Spirit", 1, 1, "+", " to Strength and Intelligence", 8, 10, 2.92));
            SuffixesInt.Add(new Affix("of Cunning", 1, 1, "+", " to Dexterity and Intelligence", 8, 10, 2.92));
            SuffixesInt.Add(new Affix("of Adaption", 1, 1, "+", " to all Attributes", 6, 8, 1.95));
            SuffixesInt.Add(new Affix("of Focus", 1, 1, "+", " Energy Shield gained for each Enemy hit by your Attacks", 2, 3, 3.25));
            SuffixesInt.Add(new Affix("of Raiding", 1, 1, "", "% increased Rarity of Items found", 4, 6, 0.97));
            SuffixesInt.Add(new Affix("of Menace", 1, 1, "", "% increased Global Critical Strike Chance", 8, 12, 1.62));
            SuffixesInt.Add(new Affix("of Potency", 1, 1, "+", "% to Global Critical Strike Multiplier", 9, 12, 1.62));
            SuffixesInt.Add(new Affix("of Annihilation", 1, 1, "", "% increased Critical Strike Chance for Spells", 10, 14, 1.62));
            SuffixesInt.Add(new Affix("of the Apocalypse", 1, 1, "", "% increased Critical Strike Chance with Elemental Skills", 10, 14, 0.65));
            SuffixesInt.Add(new Affix("of Unmaking", 1, 1, "+", "% to Critical Strike Multiplier for Spells", 12, 15, 1.62));
            SuffixesInt.Add(new Affix("of the Elements", 1, 1, "+", "% to Critical Strike Multiplier with Elemental Skills", 12, 15, 0.65));
            SuffixesInt.Add(new Affix("of the Dragon", 1, 1, "+", "% to Fire Resistance", 12, 15, 1.95));
            SuffixesInt.Add(new Affix("of the Beast", 1, 1, "+", "% to Cold Resistance", 12, 15, 1.95));
            SuffixesInt.Add(new Affix("of Grounding", 1, 1, "+", "% to Lightning Resistance", 12, 15, 3.25));
            SuffixesInt.Add(new Affix("of the Hearth", 1, 1, "+", "% to Fire and Cold Resistances", 10, 12, 1.62));
            SuffixesInt.Add(new Affix("of Insulation", 1, 1, "+", "% to Fire and Lightning Resistances", 10, 12, 2.92));
            SuffixesInt.Add(new Affix("of Shelter", 1, 1, "+", "% to Cold and Lightning Resistances", 10, 12, 2.92));
            SuffixesInt.Add(new Affix("of Resistance", 1, 1, "+", "% to all Elemental Resistances", 8, 10, 1.95));
            SuffixesInt.Add(new Affix("of Order", 1, 1, "+", "% to Chaos Resistance", 7, 13, 0.65));
            SuffixesInt.Add(new Affix("of Stunning", 1, 1, "", "% increased Stun Duration on Enemies", 10, 14, 1.3));
            SuffixesInt.Add(new Affix("of Recovery", 1, 1, "", "% increased Stun and Block Recovery", 10, 14, 1.3));
            SuffixesInt.Add(new Affix("of Efficiency", 1, 1, "", "% reduced Mana Cost of Skills", 3, 5, 3.25));
            SuffixesInt.Add(new Affix("of Fending", 1, 1, "", "% chance to Knock Enemies Back on hit", 4, 6, 1.62));
            SuffixesDex.Add(new Affix("of Freezing", 1, 1, "", "% chance to Freeze", 3, 5, 1.62, "", "% increased Freeze Duration on Enemies", 12, 16));
            SuffixesDex.Add(new Affix("of Shocking", 1, 1, "", "% chance to Shock", 3, 5, 2.27, "", "% increased Shock Duration on Enemies", 12, 16));
            SuffixesDex.Add(new Affix("of Burning", 1, 1, "", "% chance to Ignite", 3, 5, 1.62, "", "% increased Ignite Duration on Enemies", 6, 8));
            SuffixesDex.Add(new Affix("of Poisoning", 1, 1, "", "% chance to Poison on Hit", 3, 5, 1.62, "", "% increased Poison Duration", 6, 8));
            SuffixesDex.Add(new Affix("of Bleeding", 1, 1, "Attacks have ", "% chance to cause Bleeding", 3, 5, 1.62, "", "% increased Bleed duration", 12, 16));
            SuffixesInt.Add(new Affix("of Venom", 1, 1, "", "% increased Damage with Poison", 16, 20, 1.62));
            SuffixesInt.Add(new Affix("of Haemophilia", 1, 1, "", "% increased Damage with Bleeding", 16, 20, 1.62));
            SuffixesInt.Add(new Affix("of Combusting", 1, 1, "", "% increased Burning Damage", 16, 20, 3.25));
            SuffixesInt.Add(new Affix("of the Wall", 1, 1, "Minions have ", "% Chance to Block", 2, 4, 2.27));
            SuffixesInt.Add(new Affix("of Resilience", 1, 1, "Minions have +", "% to all Elemental Resistances", 6, 10, 2.27));
            SuffixesInt.Add(new Affix("of Runes", 1, 1, "Totems gain +", "% to all Elemental Resistances", 6, 10, 1.62));

            PrefixesStr.Add(new Affix("Brutal", 1, 1, "", "% increased Physical Damage with Maces", 14, 16, 2.84));
            PrefixesStr.Add(new Affix("Sinister", 1, 1, "", "% increased Physical Damage with Axes", 14, 16, 2.84));
            PrefixesStr.Add(new Affix("Vicious", 1, 1, "", "% increased Physical Damage with Swords", 14, 16, 2.84));
            PrefixesStr.Add(new Affix("Judging", 1, 1, "", "% increased Physical Damage with Staves", 14, 16, 2.84));
            PrefixesStr.Add(new Affix("Soldier's", 1, 1, "", "% increased Physical Damage with One Handed Melee Weapons", 12, 14, 2.84));
            PrefixesStr.Add(new Affix("Champion's", 1, 1, "", "% increased Physical Damage with Two Handed Melee Weapons", 12, 14, 2.84));
            PrefixesStr.Add(new Affix("Gladiator's", 1, 1, "", "% increased Physical Weapon Damage while Dual Wielding", 12, 14, 2.84));
            PrefixesStr.Add(new Affix("Flaming", 1, 1, "", "% increased Fire Damage", 14, 16, 2.84));
            PrefixesStr.Add(new Affix("Chilling", 1, 1, "", "% increased Cold Damage", 14, 16, 2.27));
            PrefixesStr.Add(new Affix("Humming", 1, 1, "", "% increased Lightning Damage", 14, 16, 2.27));
            PrefixesStr.Add(new Affix("Sharpened", 1, 1, "", "% increased Physical Damage", 14, 16, 2.84));
            PrefixesStr.Add(new Affix("Chaotic", 1, 1, "", "% increased Chaos Damage", 9, 13, 1.14));
            PrefixesStr.Add(new Affix("Beating", 1, 1, "", "% increased Attack Speed with Maces", 6, 8, 2.84));
            PrefixesStr.Add(new Affix("Cleaving", 1, 1, "", "% increased Attack Speed with Axes", 6, 8, 2.84));
            PrefixesStr.Add(new Affix("Fencing", 1, 1, "", "% increased Attack Speed with Swords", 6, 8, 2.84));
            PrefixesStr.Add(new Affix("Blunt", 1, 1, "", "% increased Attack Speed with Staves", 6, 8, 2.84));
            PrefixesStr.Add(new Affix("Bandit's", 1, 1, "", "% increased Attack Speed with One Handed Melee Weapons", 4, 6, 2.84));
            PrefixesStr.Add(new Affix("Warrior's", 1, 1, "", "% increased Attack Speed with Two Handed Melee Weapons", 4, 6, 2.84));
            PrefixesStr.Add(new Affix("Harmonic", 1, 1, "", "% increased Attack Speed while Dual Wielding", 4, 6, 2.84));
            PrefixesStr.Add(new Affix("Charging", 1, 1, "", "% increased Attack Speed while holding a Shield", 4, 6, 2.84));
            PrefixesStr.Add(new Affix("Flanking", 1, 1, "", "% increased Melee Physical Damage while holding a Shield", 12, 14, 2.84));
            PrefixesStr.Add(new Affix("Vivid", 1, 1, "", "% increased maximum Life", 5, 7, 2.84));
            PrefixesStr.Add(new Affix("Enlightened", 1, 1, "", "% increased maximum Mana", 6, 8, 1.42));
            PrefixesStr.Add(new Affix("Energetic", 1, 1, "", "% increased Mana Regeneration Rate", 12, 15, 1.42));
            PrefixesStr.Add(new Affix("Hungering", 1, 1, "0.", "% of Physical Attack Damage Leeched as Life", 2, 4, 2.84));
            PrefixesStr.Add(new Affix("Armoured", 1, 1, "", "% increased Armour", 14, 18, 2.84));
            PrefixesStr.Add(new Affix("Harming", 1, 1, "", "% increased Critical Strike Chance with One Handed Melee Weapons", 14, 18, 1.42));
            PrefixesStr.Add(new Affix("Sundering", 1, 1, "", "% increased Critical Strike Chance with Two Handed Melee Weapons", 14, 18, 1.42));
            PrefixesStr.Add(new Affix("Technical", 1, 1, "", "% increased Weapon Critical Strike Chance while Dual Wielding", 14, 18, 1.42));
            PrefixesStr.Add(new Affix("Incinerating", 1, 1, "", "% increased Critical Strike Chance with Fire Skills", 14, 18, 1.42));
            PrefixesStr.Add(new Affix("Avalanching", 1, 1, "", "% increased Critical Strike Chance with Cold Skills", 14, 18, 1.14));
            PrefixesStr.Add(new Affix("Thundering", 1, 1, "", "% increased Critical Strike Chance with Lightning Skills", 14, 18, 1.14));
            PrefixesStr.Add(new Affix("Piercing", 1, 1, "+", "% to Critical Strike Multiplier with One Handed Melee Weapons", 15, 18, 1.42));
            PrefixesStr.Add(new Affix("Rupturing", 1, 1, "+", "% to Critical Strike Multiplier with Two Handed Melee Weapons", 15, 18, 1.42));
            PrefixesStr.Add(new Affix("Puncturing", 1, 1, "+", "% to Critical Strike Multiplier while Dual Wielding", 15, 18, 1.42));
            PrefixesStr.Add(new Affix("Infernal", 1, 1, "+", "% to Critical Strike Multiplier with Fire Skills", 15, 18, 1.42));
            PrefixesStr.Add(new Affix("Arctic", 1, 1, "+", "% to Critical Strike Multiplier with Cold Skills", 15, 18, 1.14));
            PrefixesStr.Add(new Affix("Surging", 1, 1, "+", "% to Critical Strike Multiplier with Lightning Skills", 15, 18, 1.14));
            PrefixesStr.Add(new Affix("Parrying", 1, 1, "", "% additional Block Chance while Dual Wielding", 1, 1, 1.99));
            PrefixesStr.Add(new Affix("Shielding", 1, 1, "+", "% Chance to Block with Shields", 1, 1, 1.99));
            PrefixesStr.Add(new Affix("Deflecting", 1, 1, "", "% additional Chance to Block with STaves", 1, 1, 1.99));
            PrefixesStr.Add(new Affix("Dissipating", 1, 1, "", "% additional Chance to Block Spells while Dual Wielding", 1, 1, 1.99));
            PrefixesStr.Add(new Affix("Thwarting", 1, 1, "", "% additional Chance to Block Spells with SHields", 1, 1, 1.99));
            PrefixesStr.Add(new Affix("Halting", 1, 1, "", "% additional Chance to Block Spells with Staves", 1, 1, 1.99));
            PrefixesStr.Add(new Affix("Shaman's", 1, 1, "", "% increased Totem Damage", 12, 16, 1.99));
            PrefixesStr.Add(new Affix("Carved", 1, 1, "", "% increased Totem Life", 8, 12, 1.99));

            SuffixesStr.Add(new Affix("of Combat", 1, 1, "", "% increased Melee Damage", 10, 12, 3.32));
            SuffixesStr.Add(new Affix("of Archery", 1, 1, "", "% increased Projectile Damage", 10, 12, 2.66));
            SuffixesStr.Add(new Affix("of Wounding", 1, 1, "", "% increased Damage", 8, 10, 2.33));
            SuffixesStr.Add(new Affix("of Entropy", 1, 1, "", "% increased Damage over Time", 10, 12, 3.32));
            SuffixesStr.Add(new Affix("of Blasting", 1, 1, "", "% increased Area Damage", 10, 12, 3.32));
            SuffixesStr.Add(new Affix("of Berserking", 1, 1, "", "% increased Attack Speed", 3, 5, 3.32));
            SuffixesStr.Add(new Affix("of Soaring", 1, 1, "", "% increased Projectile Speed", 6, 8, 1.99));
            SuffixesStr.Add(new Affix("of Zeal", 1, 1, "", "% increased Attack and Cast Speed", 2, 4, 2.33));
            SuffixesStr.Add(new Affix("of Strength", 1, 1, "+", " to Strength", 12, 16, 3.32));
            SuffixesStr.Add(new Affix("of Dexterity", 1, 1, "+", " to Dexterity", 12, 16, 1.99));
            SuffixesStr.Add(new Affix("of Intelligence", 1, 1, "+", " to Intelligence", 12, 16, 1.99));
            SuffixesStr.Add(new Affix("of Athletics", 1, 1, "+", " to Strength and Dexterity", 8, 10, 2.99));
            SuffixesStr.Add(new Affix("of Spirit", 1, 1, "+", " to Strength and Intelligence", 8, 10, 2.99));
            SuffixesStr.Add(new Affix("of Cunning", 1, 1, "+", " to Dexterity and Intelligence", 8, 10, 1.66));
            SuffixesStr.Add(new Affix("of Adaption", 1, 1, "+", " to all Attributes", 6, 8, 1.99));
            SuffixesStr.Add(new Affix("of Rejuvenation", 1, 1, "+", " Life gained for each Enemy hit by your Attacks", 2, 3, 3.32));
            SuffixesStr.Add(new Affix("of Raiding", 1, 1, "", "% increased Rarity of Items found", 4, 6, 1));
            SuffixesStr.Add(new Affix("of Menace", 1, 1, "", "% increased Global Critical Strike Chance", 8, 12, 1.66));
            SuffixesStr.Add(new Affix("of Potency", 1, 1, "+", "% to Global Critical Strike Multiplier", 9, 12, 1.66));
            SuffixesStr.Add(new Affix("of Weight", 1, 1, "", "% increased Melee Critical Strike Chance", 10, 14, 1.66));
            SuffixesStr.Add(new Affix("of the Apocalypse", 1, 1, "", "% increased Critical Strike Chance with Elemental Skills", 10, 14, 0.66));
            SuffixesStr.Add(new Affix("of Demolishing", 1, 1, "+", "% to Melee Critical Strike Multiplier", 12, 15, 1.66));
            SuffixesStr.Add(new Affix("of the Elements", 1, 1, "+", "% to Critical Strike Multiplier with Elemental Skills", 12, 15, 0.66));
            SuffixesStr.Add(new Affix("of the Dragon", 1, 1, "+", "% to Fire Resistance", 12, 15, 3.32));
            SuffixesStr.Add(new Affix("of the Beast", 1, 1, "+", "% to Cold Resistance", 12, 15, 1.99));
            SuffixesStr.Add(new Affix("of Grounding", 1, 1, "+", "% to Lightning Resistance", 12, 15, 1.99));
            SuffixesStr.Add(new Affix("of the Hearth", 1, 1, "+", "% to Fire and Cold Resistances", 10, 12, 2.99));
            SuffixesStr.Add(new Affix("of Insulation", 1, 1, "+", "% to Fire and Lightning Resistances", 10, 12, 2.99));
            SuffixesStr.Add(new Affix("of Shelter", 1, 1, "+", "% to Cold and Lightning Resistances", 10, 12, 1.66));
            SuffixesStr.Add(new Affix("of Resistance", 1, 1, "+", "% to all Elemental Resistances", 8, 10, 1.99));
            SuffixesStr.Add(new Affix("of Order", 1, 1, "+", "% to Chaos Resistance", 7, 13, 0.66));
            SuffixesStr.Add(new Affix("of Stunning", 1, 1, "", "% increased Stun Duration on Enemies", 10, 14, 2.66));
            SuffixesStr.Add(new Affix("of Recovery", 1, 1, "", "% increased Stun and Block Recovery", 10, 14, 2.66));
            SuffixesStr.Add(new Affix("of Efficiency", 1, 1, "", "% reduced Mana Cost of Skills", 3, 5, 3.32));
            SuffixesStr.Add(new Affix("of Fending", 1, 1, "", "% chance to Knock Enemies Back on hit", 4, 6, 1.66));
            SuffixesDex.Add(new Affix("of Freezing", 1, 1, "", "% chance to Freeze", 3, 5, 1.66, "", "% increased Freeze Duration on Enemies", 12, 16));
            SuffixesDex.Add(new Affix("of Shocking", 1, 1, "", "% chance to Shock", 3, 5, 1.66, "", "% increased Shock Duration on Enemies", 12, 16));
            SuffixesDex.Add(new Affix("of Burning", 1, 1, "", "% chance to Ignite", 3, 5, 2.33, "", "% increased Ignite Duration on Enemies", 6, 8));
            SuffixesDex.Add(new Affix("of Poisoning", 1, 1, "", "% chance to Poison on Hit", 3, 5, 1.66, "", "% increased Poison Duration", 6, 8));
            SuffixesDex.Add(new Affix("of Bleeding", 1, 1, "Attacks have ", "% chance to cause Bleeding", 3, 5, 2.33, "", "% increased Bleed duration", 12, 16));
            SuffixesStr.Add(new Affix("of Venom", 1, 1, "", "% increased Damage with Poison", 16, 20, 1.66));
            SuffixesStr.Add(new Affix("of Haemophilia", 1, 1, "", "% increased Damage with Bleeding", 16, 20, 3.32));
            SuffixesStr.Add(new Affix("of Combusting", 1, 1, "", "% increased Burning Damage", 16, 20, 3.32));
            SuffixesStr.Add(new Affix("of Runes", 1, 1, "Totems gain +", "% to all Elemental Resistances", 6, 10, 2.33));
        }
    }
}

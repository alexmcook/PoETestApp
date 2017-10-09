﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoETestApp
{
    class Body
    {
        public static List<Affix> PrefixesDex { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesDex { get; set; } = new List<Affix>();
        public static List<Affix> PrefixesInt { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesInt { get; set; } = new List<Affix>();
        public static List<Affix> PrefixesStr { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesStr { get; set; } = new List<Affix>();

        public static void PopulateAffixes()
        {
            PrefixesInt.Add(new Affix("Hale", 12, 1, "+", " to maximum Life", 3, 9, 1.8));
            PrefixesInt.Add(new Affix("Healthy", 11, 5, "+", " to maximum Life", 10, 19, 1.8));
            PrefixesInt.Add(new Affix("Sanguine", 10, 11, "+", " to maximum Life", 20, 29, 1.8));
            PrefixesInt.Add(new Affix("Stalwart", 9, 18, "+", " to maximum Life", 30, 39, 1.8));
            PrefixesInt.Add(new Affix("Stout", 8, 24, "+", " to maximum Life", 40, 49, 1.8));
            PrefixesInt.Add(new Affix("Robust", 7, 30, "+", " to maximum Life", 50, 59, 1.8));
            PrefixesInt.Add(new Affix("Rotund", 6, 36, "+", " to maximum Life", 60, 69, 1.8));
            PrefixesInt.Add(new Affix("Virile", 5, 44, "+", " to maximum Life", 70, 79, 1.8));
            PrefixesInt.Add(new Affix("Athlete's", 4, 54, "+", " to maximum Life", 80, 89, 1.8));
            PrefixesInt.Add(new Affix("Fecund", 3, 64, "+", " to maximum Life", 90, 99, 1.8));
            PrefixesInt.Add(new Affix("Vigorous", 2, 73, "+", " to maximum Life", 100, 109, 1.8));
            PrefixesInt.Add(new Affix("Rapturous", 1, 81, "+", " to maximum Life", 110, 119, 1.8));
            PrefixesInt.Add(new Affix("Beryl", 12, 1, "+", " to maximum Mana", 15, 19, 1.8));
            PrefixesInt.Add(new Affix("Cobalt", 11, 11, "+", " to maximum Mana", 20, 24, 1.8));
            PrefixesInt.Add(new Affix("Azure", 10, 17, "+", " to maximum Mana", 25, 29, 1.8));
            PrefixesInt.Add(new Affix("Sapphire", 9, 23, "+", " to maximum Mana", 30, 34, 1.8));
            PrefixesInt.Add(new Affix("Cerulean", 8, 29, "+", " to maximum Mana", 35, 39, 1.8));
            PrefixesInt.Add(new Affix("Aqua", 7, 35, "+", " to maximum Mana", 40, 44, 1.8));
            PrefixesInt.Add(new Affix("Opalescent", 6, 42, "+", " to maximum Mana", 45, 49, 1.8));
            PrefixesInt.Add(new Affix("Gentian", 5, 51, "+", " to maximum Mana", 50, 54, 1.8));
            PrefixesInt.Add(new Affix("Chalybeous", 4, 60, "+", " to maximum Mana", 55, 59, 1.8));
            PrefixesInt.Add(new Affix("Mazarine", 3, 69, "+", " to maximum Mana", 60, 64, 1.8));
            PrefixesInt.Add(new Affix("Blue", 2, 75, "+", " to maximum Mana", 65, 68, 1.8));
            PrefixesInt.Add(new Affix("Zaffre", 1, 81, "+", " to maximum Mana", 69, 73, 1.8));
            PrefixesInt.Add(new Affix("Shining", 11, 3, "+", " to maximum Energy Shield", 3, 5, 1.8));
            PrefixesInt.Add(new Affix("Glimmering", 10, 11, "+", " to maximum Energy Shield", 6, 11, 1.8));
            PrefixesInt.Add(new Affix("Glittering", 9, 17, "+", " to maximum Energy Shield", 12, 16, 1.8));
            PrefixesInt.Add(new Affix("Glowing", 8, 23, "+", " to maximum Energy Shield", 17, 23, 1.8));
            PrefixesInt.Add(new Affix("Radiating", 7, 29, "+", " to maximum Energy Shield", 24, 30, 1.8));
            PrefixesInt.Add(new Affix("Pulsing", 6, 35, "+", " to maximum Energy Shield", 31, 38, 1.8));
            PrefixesInt.Add(new Affix("Seething", 5, 43, "+", " to maximum Energy Shield", 39, 49, 1.8));
            PrefixesInt.Add(new Affix("Blazing", 4, 51, "+", " to maximum Energy Shield", 50, 61, 1.8));
            PrefixesInt.Add(new Affix("Scintillating", 3, 60, "+", " to maximum Energy Shield", 62, 76, 1.8));
            PrefixesInt.Add(new Affix("Incandescent", 2, 69, "+", " to maximum Energy Shield", 77, 90, 1.8));
            PrefixesInt.Add(new Affix("Resplendent", 1, 75, "+", " to maximum Energy Shield", 91, 100, 1.8));
            PrefixesInt.Add(new Affix("Protective", 7, 3, "", "% increased Energy Shield", 11, 28, 1.8));
            PrefixesInt.Add(new Affix("Strong-Willed", 6, 18, "", "% increased Energy Shield", 27, 42, 1.8));
            PrefixesInt.Add(new Affix("Resolute", 5, 30, "", "% increased Energy Shield", 43, 55, 1.8));
            PrefixesInt.Add(new Affix("Fearless", 4, 44, "", "% increased Energy Shield", 56, 67, 1.8));
            PrefixesInt.Add(new Affix("Dauntless", 3, 60, "", "% increased Energy Shield", 68, 79, 1.8));
            PrefixesInt.Add(new Affix("Indomitable", 2, 72, "", "% increased Energy Shield", 80, 91, 1.8));
            PrefixesInt.Add(new Affix("Unassailable", 1, 84, "", "% increased Energy Shield", 92, 100, 1.8));
            PrefixesInt.Add(new Affix("Pixie's", 6, 3, "", "% increased Energy Shield", 6, 13, 1.8, "", "% increased Stun and Block Recovery", 6, 7));
            PrefixesInt.Add(new Affix("Gremlin's", 5, 18, "", "% increased Energy Shield", 14, 20, 1.8, "", "% increased Stun and Block Recovery", 8, 9));
            PrefixesInt.Add(new Affix("Boggart's", 4, 30, "", "% increased Energy Shield", 21, 26, 1.8, "", "% increased Stun and Block Recovery", 10, 11));
            PrefixesInt.Add(new Affix("Naga's", 3, 44, "", "% increased Energy Shield", 27, 32, 1.8, "", "% increased Stun and Block Recovery", 12, 13));
            PrefixesInt.Add(new Affix("Djinn's", 2, 60, "", "% increased Energy Shield", 33, 38, 1.8, "", "% increased Stun and Block Recovery", 14, 15));
            PrefixesInt.Add(new Affix("Seraphim's", 1, 78, "", "% increased Energy Shield", 39, 42, 1.8, "", "% increased Stun and Block Recovery", 16, 17));
            PrefixesInt.Add(new Affix("Monk's", 4, 30, "+", " to maximum Energy Shield", 8, 10, 1.8, "+", " to maximum Life", 18, 23));
            PrefixesInt.Add(new Affix("Prior's", 3, 46, "+", " to maximum Energy Shield", 11, 15, 1.8, "+", " to maximum Life", 24, 28));
            PrefixesInt.Add(new Affix("Abbot's", 2, 62, "+", " to maximum Energy Shield", 16, 25, 1.8, "+", " to maximum Life", 29, 33));
            PrefixesInt.Add(new Affix("Exarch's", 1, 78, "+", " to maximum Energy Shield", 26, 30, 0.9, "+", " to maximum Life", 34, 38));
            PrefixesInt.Add(new Affix("Thorny", 4, 1, "Reflects ", " Physical Damage to Melee Attackers", 1, 4, 1.8));
            PrefixesInt.Add(new Affix("Spiny", 3, 10, "Reflects ", " Physical Damage to Melee Attackers", 5, 10, 1.8));
            PrefixesInt.Add(new Affix("Barbed", 2, 20, "Reflects ", " Physical Damage to Melee Attackers", 11, 24, 1.8));
            PrefixesInt.Add(new Affix("Jagged", 1, 35, "Reflects ", " Physical Damage to Melee Attackers", 25, 50, 1.8));

            SuffixesInt.Add(new Affix("of the Pupil", 9, 1, "+", " to Intelligence", 8, 12, 1.95));
            SuffixesInt.Add(new Affix("of the Student", 8, 11, "+", " to Intelligence", 13, 17, 1.95));
            SuffixesInt.Add(new Affix("of the Prodigy", 7, 22, "+", " to Intelligence", 18, 22, 1.95));
            SuffixesInt.Add(new Affix("of the Augur", 6, 33, "+", " to Intelligence", 23, 27, 1.95));
            SuffixesInt.Add(new Affix("of the Philosopher", 5, 44, "+", " to Intelligence", 28, 32, 1.95));
            SuffixesInt.Add(new Affix("of the Sage", 4, 55, "+", " to Intelligence", 33, 37, 1.95));
            SuffixesInt.Add(new Affix("of the Savant", 3, 66, "+", " to Intelligence", 38, 42, 1.95));
            SuffixesInt.Add(new Affix("of the Virtuoso", 2, 74, "+", " to Intelligence", 43, 50, 1.95));
            SuffixesInt.Add(new Affix("of the Genius", 1, 82, "+", " to Intelligence", 51, 55, 1.95));
            SuffixesInt.Add(new Affix("of the Newt", 6, 1, "", " Life Regenerated per second", 1, 2, 1.95));
            SuffixesInt.Add(new Affix("of the Lizard", 5, 18, "", " Life Regenerated per second", 2, 3, 1.95));
            SuffixesInt.Add(new Affix("of the Starfish", 4, 30, "", " Life Regenerated per second", 3, 4, 1.95));
            SuffixesInt.Add(new Affix("of the Hydra", 3, 44, "", " Life Regenerated per second", 4, 5, 1.95));
            SuffixesInt.Add(new Affix("of the Troll", 2, 59, "", " Life Regenerated per second", 5, 6, 1.95));
            SuffixesInt.Add(new Affix("of the Phoenix", 1, 78, "", " Life Regenerated per second", 6, 7, 1.95));
            SuffixesInt.Add(new Affix("of the Whelpling", 8, 1, "+", "% to Fire Resistance", 6, 11, 1.95));
            SuffixesInt.Add(new Affix("of the Salamander", 7, 12, "+", "% to Fire Resistance", 12, 17, 1.95));
            SuffixesInt.Add(new Affix("of the Drake", 6, 24, "+", "% to Fire Resistance", 18, 23, 1.95));
            SuffixesInt.Add(new Affix("of the Kiln", 5, 36, "+", "% to Fire Resistance", 24, 29, 1.95));
            SuffixesInt.Add(new Affix("of the Furnace", 4, 48, "+", "% to Fire Resistance", 30, 35, 1.95));
            SuffixesInt.Add(new Affix("of the Volcano", 3, 60, "+", "% to Fire Resistance", 36, 41, 1.95));
            SuffixesInt.Add(new Affix("of the Magma", 2, 72, "+", "% to Fire Resistance", 42, 45, 1.95));
            SuffixesInt.Add(new Affix("of Tzteosh", 1, 84, "+", "% to Fire Resistance", 46, 48, 1.95));
            SuffixesInt.Add(new Affix("of the Inuit", 8, 1, "+", "% to Cold Resistance", 6, 11, 1.95));
            SuffixesInt.Add(new Affix("of the Seal", 7, 14, "+", "% to Cold Resistance", 12, 17, 1.95));
            SuffixesInt.Add(new Affix("of the Penguin", 6, 26, "+", "% to Cold Resistance", 18, 23, 1.95));
            SuffixesInt.Add(new Affix("of the Yeti", 5, 38, "+", "% to Cold Resistance", 24, 29, 1.95));
            SuffixesInt.Add(new Affix("of the Walrus", 4, 50, "+", "% to Cold Resistance", 30, 35, 1.95));
            SuffixesInt.Add(new Affix("of the Polar Bear", 3, 60, "+", "% to Cold Resistance", 36, 41, 1.95));
            SuffixesInt.Add(new Affix("of the Ice", 2, 72, "+", "% to Cold Resistance", 42, 45, 1.95));
            SuffixesInt.Add(new Affix("of Haast", 1, 84, "+", "% to Cold Resistance", 46, 48, 1.95));
            SuffixesInt.Add(new Affix("of the Cloud", 8, 1, "+", "% to Lightning Resistance", 6, 11, 1.95));
            SuffixesInt.Add(new Affix("of the Squall", 7, 13, "+", "% to Lightning Resistance", 12, 17, 1.95));
            SuffixesInt.Add(new Affix("of the Storm", 6, 25, "+", "% to Lightning Resistance", 18, 23, 1.95));
            SuffixesInt.Add(new Affix("of the Thunderhead", 5, 37, "+", "% to Lightning Resistance", 24, 29, 1.95));
            SuffixesInt.Add(new Affix("of the Tempest", 4, 49, "+", "% to Lightning Resistance", 30, 35, 1.95));
            SuffixesInt.Add(new Affix("of the Maelstrom", 3, 60, "+", "% to Lightning Resistance", 36, 41, 1.95));
            SuffixesInt.Add(new Affix("of the Lightning", 2, 72, "+", "% to Lightning Resistance", 42, 45, 1.95));
            SuffixesInt.Add(new Affix("of Ephij", 1, 84, "+", "% to Lightning Resistance", 46, 48, 1.95));
            SuffixesInt.Add(new Affix("of the Lost", 6, 16, "+", "% to Chaos Resistance", 5, 10, 0.49));
            SuffixesInt.Add(new Affix("of Banishment", 5, 30, "+", "% to Chaos Resistance", 11, 15, 0.49));
            SuffixesInt.Add(new Affix("of Eviction", 4, 44, "+", "% to Chaos Resistance", 16, 20, 0.49));
            SuffixesInt.Add(new Affix("of Expulsion", 3, 56, "+", "% to Chaos Resistance", 21, 25, 0.49));
            SuffixesInt.Add(new Affix("of Exile", 2, 65, "+", "% to Chaos Resistance", 26, 30, 0.49));
            SuffixesInt.Add(new Affix("of Bameth", 1, 81, "+", "% to Chaos Resistance", 31, 35, 0.49));
            SuffixesInt.Add(new Affix("of Thick Skin", 6, 1, "", "% increased Stun and Block Recovery", 11, 13, 1.95));
            SuffixesInt.Add(new Affix("of Stone Skin", 5, 17, "", "% increased Stun and Block Recovery", 14, 16, 1.95));
            SuffixesInt.Add(new Affix("of Iron Skin", 4, 28, "", "% increased Stun and Block Recovery", 17, 19, 1.95));
            SuffixesInt.Add(new Affix("of Steel Skin", 3, 42, "", "% increased Stun and Block Recovery", 20, 22, 1.95));
            SuffixesInt.Add(new Affix("of Adamantite Skin", 2, 56, "", "% increased Stun and Block Recovery", 23, 25, 1.95));
            SuffixesInt.Add(new Affix("of Corundum Skin", 1, 79, "", "% increased Stun and Block Recovery", 26, 28, 1.95));
            SuffixesInt.Add(new Affix("of the Worthy", 2, 36, "", "% reduced Attribute Requirements", 18, 18, 1.66));
            SuffixesInt.Add(new Affix("of the Apt", 1, 60, "", "% reduced Attribute Requirements", 32, 32, 1.66));
            SuffixesInt.Add(new Affix("of Vibrance", 2, 25, "0.", "% of Energy Shield Regenerated per second", 6, 6, 3.91));
            SuffixesInt.Add(new Affix("of Exuberance", 1, 85, "", "% of Energy Shield Regenerated per second", 1, 1, 1.95));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoETestApp
{
    public static class Shield
    {
        public static List<Affix> PrefixesDex { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesDex { get; set; } = new List<Affix>();
        public static List<Affix> PrefixesInt { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesInt { get; set; } = new List<Affix>();
        public static List<Affix> PrefixesStr { get; set; } = new List<Affix>();
        public static List<Affix> SuffixesStr { get; set; } = new List<Affix>();

        public static void PopulateAffixes()
        {
            PrefixesInt.Add(new Affix("Hale", 11, 1, "+", " to maximum Life", 3, 9, 1.6));
            PrefixesInt.Add(new Affix("Healthy", 10, 5, "+", " to maximum Life", 10, 19, 1.6));
            PrefixesInt.Add(new Affix("Sanguine", 9, 11, "+", " to maximum Life", 20, 29, 1.6));
            PrefixesInt.Add(new Affix("Stalwart", 8, 18, "+", " to maximum Life", 30, 39, 1.6));
            PrefixesInt.Add(new Affix("Stout", 7, 24, "+", " to maximum Life", 40, 49, 1.6));
            PrefixesInt.Add(new Affix("Robust", 6, 30, "+", " to maximum Life", 50, 59, 1.6));
            PrefixesInt.Add(new Affix("Rotund", 5, 36, "+", " to maximum Life", 60, 69, 1.6));
            PrefixesInt.Add(new Affix("Virile", 4, 44, "+", " to maximum Life", 70, 79, 1.6));
            PrefixesInt.Add(new Affix("Athlete's", 3, 54, "+", " to maximum Life", 80, 89, 1.6));
            PrefixesInt.Add(new Affix("Fecund", 2, 64, "+", " to maximum Life", 90, 99, 1.6));
            PrefixesInt.Add(new Affix("Vigorous", 1, 73, "+", " to maximum Life", 100, 109, 1.6));
            PrefixesInt.Add(new Affix("Beryl", 12, 1, "+", " to maximum Mana", 15, 19, 1.6));
            PrefixesInt.Add(new Affix("Cobalt", 11, 11, "+", " to maximum Mana", 20, 24, 1.6));
            PrefixesInt.Add(new Affix("Azure", 10, 17, "+", " to maximum Mana", 25, 29, 1.6));
            PrefixesInt.Add(new Affix("Sapphire", 9, 23, "+", " to maximum Mana", 30, 34, 1.6));
            PrefixesInt.Add(new Affix("Cerulean", 8, 29, "+", " to maximum Mana", 35, 39, 1.6));
            PrefixesInt.Add(new Affix("Aqua", 7, 35, "+", " to maximum Mana", 40, 44, 1.6));
            PrefixesInt.Add(new Affix("Opalescent", 6, 42, "+", " to maximum Mana", 45, 49, 1.6));
            PrefixesInt.Add(new Affix("Gentian", 5, 51, "+", " to maximum Mana", 50, 54, 1.6));
            PrefixesInt.Add(new Affix("Chalybeous", 4, 60, "+", " to maximum Mana", 55, 59, 1.6));
            PrefixesInt.Add(new Affix("Mazarine", 3, 69, "+", " to maximum Mana", 60, 64, 1.6));
            PrefixesInt.Add(new Affix("Blue", 2, 75, "+", " to maximum Mana", 65, 68, 1.6));
            PrefixesInt.Add(new Affix("Zaffre", 1, 81, "+", " to maximum Mana", 69, 73, 1.6));
            PrefixesInt.Add(new Affix("Shining", 10, 3, "+", " to maximum Energy Shield", 3, 5, 1.6));
            PrefixesInt.Add(new Affix("Glimmering", 9, 11, "+", " to maximum Energy Shield", 6, 11, 1.6));
            PrefixesInt.Add(new Affix("Glittering", 8, 17, "+", " to maximum Energy Shield", 12, 16, 1.6));
            PrefixesInt.Add(new Affix("Glowing", 7, 23, "+", " to maximum Energy Shield", 17, 23, 1.6));
            PrefixesInt.Add(new Affix("Radiating", 6, 29, "+", " to maximum Energy Shield", 24, 30, 1.6));
            PrefixesInt.Add(new Affix("Pulsing", 5, 35, "+", " to maximum Energy Shield", 31, 38, 1.6));
            PrefixesInt.Add(new Affix("Seething", 4, 43, "+", " to maximum Energy Shield", 39, 49, 1.6));
            PrefixesInt.Add(new Affix("Blazing", 3, 51, "+", " to maximum Energy Shield", 50, 61, 1.6));
            PrefixesInt.Add(new Affix("Scintillating", 2, 60, "+", " to maximum Energy Shield", 62, 76, 1.6));
            PrefixesInt.Add(new Affix("Incandescent", 1, 69, "+", " to maximum Energy Shield", 77, 90, 1.6));
            PrefixesInt.Add(new Affix("Protective", 7, 3, "", "% increased Energy Shield", 11, 28, 1.6));
            PrefixesInt.Add(new Affix("Strong-Willed", 6, 18, "", "% increased Energy Shield", 27, 42, 1.6));
            PrefixesInt.Add(new Affix("Resolute", 5, 30, "", "% increased Energy Shield", 43, 55, 1.6));
            PrefixesInt.Add(new Affix("Fearless", 4, 44, "", "% increased Energy Shield", 56, 67, 1.6));
            PrefixesInt.Add(new Affix("Dauntless", 3, 60, "", "% increased Energy Shield", 68, 79, 1.6));
            PrefixesInt.Add(new Affix("Indomitable", 2, 72, "", "% increased Energy Shield", 80, 91, 1.6));
            PrefixesInt.Add(new Affix("Unassailable", 1, 84, "", "% increased Energy Shield", 92, 100, 1.6));
            PrefixesInt.Add(new Affix("Pixie's", 6, 3, "", "% increased Energy Shield", 6, 13, 1.6, "", "% increased Stun and Block Recovery", 6, 7));
            PrefixesInt.Add(new Affix("Gremlin's", 5, 18, "", "% increased Energy Shield", 14, 20, 1.6, "", "% increased Stun and Block Recovery", 8, 9));
            PrefixesInt.Add(new Affix("Boggart's", 4, 30, "", "% increased Energy Shield", 21, 26, 1.6, "", "% increased Stun and Block Recovery", 10, 11));
            PrefixesInt.Add(new Affix("Naga's", 3, 44, "", "% increased Energy Shield", 27, 32, 1.6, "", "% increased Stun and Block Recovery", 12, 13));
            PrefixesInt.Add(new Affix("Djinn's", 2, 60, "", "% increased Energy Shield", 33, 38, 1.6, "", "% increased Stun and Block Recovery", 14, 15));
            PrefixesInt.Add(new Affix("Seraphim's", 1, 78, "", "% increased Energy Shield", 39, 42, 1.6, "", "% increased Stun and Block Recovery", 16, 17));
            PrefixesInt.Add(new Affix("Monk's", 3, 30, "+", " to maximum Energy Shield", 8, 10, 1.6, "+", " to maximum Life", 18, 23));
            PrefixesInt.Add(new Affix("Prior's", 2, 46, "+", " to maximum Energy Shield", 11, 15, 1.6, "+", " to maximum Life", 24, 28));
            PrefixesInt.Add(new Affix("Abbot's", 1, 62, "+", " to maximum Energy Shield", 16, 25, 1.6, "+", " to maximum Life", 29, 33));
            PrefixesInt.Add(new Affix("Apprentice's", 8, 2, "", "% increased Spell Damage", 10, 19, 1.2));
            PrefixesInt.Add(new Affix("Adept's", 7, 11, "", "% increased Spell Damage", 20, 29, 1.2));
            PrefixesInt.Add(new Affix("Scholar's", 6, 23, "", "% increased Spell Damage", 30, 39, 1.2));
            PrefixesInt.Add(new Affix("Professor's", 5, 35, "", "% increased Spell Damage", 40, 49, 0.48));
            PrefixesInt.Add(new Affix("Occultist's", 4, 46, "", "% increased Spell Damage", 50, 59, 0.24));
            PrefixesInt.Add(new Affix("Incanter's", 3, 58, "", "% increased Spell Damage", 60, 69, 0.12));
            PrefixesInt.Add(new Affix("Glyphic", 2, 64, "", "% increased Spell Damage", 70, 74, 0.06));
            PrefixesInt.Add(new Affix("Runic", 1, 84, "", "% increased Spell Damage", 75, 79, 0.03));
            PrefixesInt.Add(new Affix("Searing", 8, 2, "", "% increased Fire Damage", 10, 19, 0.4));
            PrefixesInt.Add(new Affix("Sizzling", 7, 11, "", "% increased Fire Damage", 20, 29, 0.4));
            PrefixesInt.Add(new Affix("BPrefixesIntering", 6, 23, "", "% increased Fire Damage", 30, 39, 0.4));
            PrefixesInt.Add(new Affix("Cauterising", 5, 35, "", "% increased Fire Damage", 40, 49, 0.16));
            PrefixesInt.Add(new Affix("Volcanic", 4, 46, "", "% increased Fire Damage", 50, 59, 0.08));
            PrefixesInt.Add(new Affix("Magmatic", 3, 58, "", "% increased Fire Damage", 60, 69, 0.04));
            PrefixesInt.Add(new Affix("Pyroclastic", 2, 64, "", "% increased Fire Damage", 70, 74, 0.02));
            PrefixesInt.Add(new Affix("Xoph's", 1, 84, "", "% increased Fire Damage", 75, 79, 0.01));
            PrefixesInt.Add(new Affix("Bitter", 8, 2, "", "% increased Cold Damage", 10, 19, 0.4));
            PrefixesInt.Add(new Affix("Biting", 7, 11, "", "% increased Cold Damage", 20, 29, 0.4));
            PrefixesInt.Add(new Affix("Alpine", 6, 23, "", "% increased Cold Damage", 30, 39, 0.4));
            PrefixesInt.Add(new Affix("Snowy", 5, 35, "", "% increased Cold Damage", 40, 49, 0.16));
            PrefixesInt.Add(new Affix("Hailing", 4, 46, "", "% increased Cold Damage", 50, 59, 0.08));
            PrefixesInt.Add(new Affix("Crystalline", 3, 58, "", "% increased Cold Damage", 60, 69, 0.04));
            PrefixesInt.Add(new Affix("Cryomancer's", 2, 64, "", "% increased Cold Damage", 70, 74, 0.02));
            PrefixesInt.Add(new Affix("Tul's", 1, 84, "", "% increased Cold Damage", 75, 79, 0.01));
            PrefixesInt.Add(new Affix("Charged", 8, 2, "", "% increased Lightning Damage", 10, 19, 0.4));
            PrefixesInt.Add(new Affix("Hissing", 7, 11, "", "% increased Lightning Damage", 20, 29, 0.4));
            PrefixesInt.Add(new Affix("Bolting", 6, 23, "", "% increased Lightning Damage", 30, 39, 0.4));
            PrefixesInt.Add(new Affix("Coursing", 5, 35, "", "% increased Lightning Damage", 40, 49, 0.16));
            PrefixesInt.Add(new Affix("Striking", 4, 46, "", "% increased Lightning Damage", 50, 59, 0.08));
            PrefixesInt.Add(new Affix("Smiting", 3, 58, "", "% increased Lightning Damage", 60, 69, 0.04));
            PrefixesInt.Add(new Affix("Ionising", 2, 64, "", "% increased Lightning Damage", 70, 74, 0.02));
            PrefixesInt.Add(new Affix("Esh's", 1, 84, "", "% increased Lightning Damage", 75, 79, 0.01));
            PrefixesInt.Add(new Affix("Flame Spinner's", 2, 2, "+", " to Level of Socketed Fire Gems", 1, 1, 0.8));
            PrefixesInt.Add(new Affix("Lava Caller's", 1, 55, "+", " to Level of Socketed Fire Gems", 2, 2, 0.8));
            PrefixesInt.Add(new Affix("Frost Weaver's", 2, 2, "+", " to Level of Socketed Cold Gems", 1, 1, 0.8));
            PrefixesInt.Add(new Affix("Winterbringer's", 1, 55, "+", " to Level of Socketed Cold Gems", 2, 2, 0.8));
            PrefixesInt.Add(new Affix("Thunder Lord's", 2, 2, "+", " to Level of Socketed Lightning Gems", 1, 1, 0.8));
            PrefixesInt.Add(new Affix("Tempest King's", 1, 55, "+", " to Level of Socketed Lightning Gems", 2, 2, 0.8));
            PrefixesInt.Add(new Affix("NihiPrefixesInt's", 2, 4, "+", " to Level of Socketed Chaos Gems", 1, 1, 0.6));
            PrefixesInt.Add(new Affix("Anarchist's", 1, 55, "+", " to Level of Socketed Chaos Gems", 2, 2, 0.6));
            PrefixesInt.Add(new Affix("Thorny", 4, 1, "Reflects ", " Physical Damage to Melee Attackers", 1, 4, 1.6));
            PrefixesInt.Add(new Affix("Spiny", 3, 10, "Reflects ", " Physical Damage to Melee Attackers", 5, 10, 1.6));
            PrefixesInt.Add(new Affix("Barbed", 2, 20, "Reflects ", " Physical Damage to Melee Attackers", 11, 24, 1.6));
            PrefixesInt.Add(new Affix("Jagged", 1, 35, "Reflects ", " Physical Damage to Melee Attackers", 25, 50, 1.6));

            SuffixesInt.Add(new Affix("of the Pupil", 9, 1, "+", " to Intelligence", 8, 12, 1.32));
            SuffixesInt.Add(new Affix("of the Student", 8, 11, "+", " to Intelligence", 13, 17, 1.32));
            SuffixesInt.Add(new Affix("of the Prodigy", 7, 22, "+", " to Intelligence", 18, 22, 1.32));
            SuffixesInt.Add(new Affix("of the Augur", 6, 33, "+", " to Intelligence", 23, 27, 1.32));
            SuffixesInt.Add(new Affix("of the Philosopher", 5, 44, "+", " to Intelligence", 28, 32, 1.32));
            SuffixesInt.Add(new Affix("of the Sage", 4, 55, "+", " to Intelligence", 33, 37, 1.32));
            SuffixesInt.Add(new Affix("of the Savant", 3, 66, "+", " to Intelligence", 38, 42, 1.32));
            SuffixesInt.Add(new Affix("of the Virtuoso", 2, 74, "+", " to Intelligence", 43, 50, 1.32));
            SuffixesInt.Add(new Affix("of the Genius", 1, 82, "+", " to Intelligence", 51, 55, 1.32));
            SuffixesInt.Add(new Affix("of Talent", 3, 2, "", "% increased Cast Speed", 5, 7, 1.32));
            SuffixesInt.Add(new Affix("of Nimbleness", 2, 15, "", "% increased Cast Speed", 8, 10, 1.32));
            SuffixesInt.Add(new Affix("of Expertise", 1, 30, "", "% increased Cast Speed", 11, 13, 1.32));
            SuffixesInt.Add(new Affix("of the Newt", 6, 1, "", " Life Regenerated per second", 1, 2, 1.32));
            SuffixesInt.Add(new Affix("of the Lizard", 5, 18, "", " Life Regenerated per second", 2, 3, 1.32));
            SuffixesInt.Add(new Affix("of the Starfish", 4, 30, "", " Life Regenerated per second", 3, 4, 1.32));
            SuffixesInt.Add(new Affix("of the Hydra", 3, 44, "", " Life Regenerated per second", 4, 5, 1.32));
            SuffixesInt.Add(new Affix("of the Troll", 2, 59, "", " Life Regenerated per second", 5, 6, 1.32));
            SuffixesInt.Add(new Affix("of the Phoenix", 1, 78, "", " Life Regenerated per second", 6, 7, 1.32));
            SuffixesInt.Add(new Affix("of Excitement", 6, 2, "", "% increased Mana Regeneration Rate", 10, 19, 1.32));
            SuffixesInt.Add(new Affix("of Joy", 5, 18, "", "% increased Mana Regeneration Rate", 20, 29, 1.32));
            SuffixesInt.Add(new Affix("of Elation", 4, 29, "", "% increased Mana Regeneration Rate", 30, 39, 1.32));
            SuffixesInt.Add(new Affix("of Bliss", 3, 42, "", "% increased Mana Regeneration Rate", 40, 49, 1.32));
            SuffixesInt.Add(new Affix("of Euphoria", 2, 55, "", "% increased Mana Regeneration Rate", 50, 59, 1.32));
            SuffixesInt.Add(new Affix("of Nirvana", 1, 79, "", "% increased Mana Regeneration Rate", 60, 69, 1.32));
            SuffixesInt.Add(new Affix("of the Whelpling", 8, 1, "+", "% to Fire Resistance", 6, 11, 1.32));
            SuffixesInt.Add(new Affix("of the Salamander", 7, 12, "+", "% to Fire Resistance", 12, 17, 1.32));
            SuffixesInt.Add(new Affix("of the Drake", 6, 24, "+", "% to Fire Resistance", 18, 23, 1.32));
            SuffixesInt.Add(new Affix("of the Kiln", 5, 36, "+", "% to Fire Resistance", 24, 29, 1.32));
            SuffixesInt.Add(new Affix("of the Furnace", 4, 48, "+", "% to Fire Resistance", 30, 35, 1.32));
            SuffixesInt.Add(new Affix("of the Volcano", 3, 60, "+", "% to Fire Resistance", 36, 41, 1.32));
            SuffixesInt.Add(new Affix("of the Magma", 2, 72, "+", "% to Fire Resistance", 42, 45, 1.32));
            SuffixesInt.Add(new Affix("of Tzteosh", 1, 84, "+", "% to Fire Resistance", 46, 48, 1.32));
            SuffixesInt.Add(new Affix("of the Inuit", 8, 1, "+", "% to Cold Resistance", 6, 11, 1.32));
            SuffixesInt.Add(new Affix("of the Seal", 7, 14, "+", "% to Cold Resistance", 12, 17, 1.32));
            SuffixesInt.Add(new Affix("of the Penguin", 6, 26, "+", "% to Cold Resistance", 18, 23, 1.32));
            SuffixesInt.Add(new Affix("of the Yeti", 5, 38, "+", "% to Cold Resistance", 24, 29, 1.32));
            SuffixesInt.Add(new Affix("of the Walrus", 4, 50, "+", "% to Cold Resistance", 30, 35, 1.32));
            SuffixesInt.Add(new Affix("of the Polar Bear", 3, 60, "+", "% to Cold Resistance", 36, 41, 1.32));
            SuffixesInt.Add(new Affix("of the Ice", 2, 72, "+", "% to Cold Resistance", 42, 45, 1.32));
            SuffixesInt.Add(new Affix("of Haast", 1, 84, "+", "% to Cold Resistance", 46, 48, 1.32));
            SuffixesInt.Add(new Affix("of the Cloud", 8, 1, "+", "% to Lightning Resistance", 6, 11, 1.32));
            SuffixesInt.Add(new Affix("of the Squall", 7, 13, "+", "% to Lightning Resistance", 12, 17, 1.32));
            SuffixesInt.Add(new Affix("of the Storm", 6, 25, "+", "% to Lightning Resistance", 18, 23, 1.32));
            SuffixesInt.Add(new Affix("of the Thunderhead", 5, 37, "+", "% to Lightning Resistance", 24, 29, 1.32));
            SuffixesInt.Add(new Affix("of the Tempest", 4, 49, "+", "% to Lightning Resistance", 30, 35, 1.32));
            SuffixesInt.Add(new Affix("of the Maelstrom", 3, 60, "+", "% to Lightning Resistance", 36, 41, 1.32));
            SuffixesInt.Add(new Affix("of the Lightning", 2, 72, "+", "% to Lightning Resistance", 42, 45, 1.32));
            SuffixesInt.Add(new Affix("of Ephij", 1, 84, "+", "% to Lightning Resistance", 46, 48, 1.32));
            SuffixesInt.Add(new Affix("of the Lost", 6, 16, "+", "% to Chaos Resistance", 5, 10, 0.33));
            SuffixesInt.Add(new Affix("of Banishment", 5, 30, "+", "% to Chaos Resistance", 11, 15, 0.33));
            SuffixesInt.Add(new Affix("of Eviction", 4, 44, "+", "% to Chaos Resistance", 16, 20, 0.33));
            SuffixesInt.Add(new Affix("of Expulsion", 3, 56, "+", "% to Chaos Resistance", 21, 25, 0.33));
            SuffixesInt.Add(new Affix("of Exile", 2, 65, "+", "% to Chaos Resistance", 26, 30, 0.33));
            SuffixesInt.Add(new Affix("of Bameth", 1, 81, "+", "% to Chaos Resistance", 31, 35, 0.33));
            SuffixesInt.Add(new Affix("of the Crystal", 5, 12, "+", "% to all Elemental Resistances", 3, 5, 1.32));
            SuffixesInt.Add(new Affix("of the Prism", 4, 24, "+", "% to all Elemental Resistances", 6, 8, 1.32));
            SuffixesInt.Add(new Affix("of the Kaleidoscope", 3, 36, "+", "% to all Elemental Resistances", 9, 11, 1.32));
            SuffixesInt.Add(new Affix("of Variegation", 2, 48, "+", "% to all Elemental Resistances", 12, 14, 1.32));
            SuffixesInt.Add(new Affix("of the Rainbow", 1, 60, "+", "% to all Elemental Resistances", 15, 16, 1.32));
            SuffixesInt.Add(new Affix("of Thick Skin", 6, 1, "", "% increased Stun and Block Recovery", 11, 13, 1.32));
            SuffixesInt.Add(new Affix("of Stone Skin", 5, 17, "", "% increased Stun and Block Recovery", 14, 16, 1.32));
            SuffixesInt.Add(new Affix("of Iron Skin", 4, 28, "", "% increased Stun and Block Recovery", 17, 19, 1.32));
            SuffixesInt.Add(new Affix("of Steel Skin", 3, 42, "", "% increased Stun and Block Recovery", 20, 22, 1.32));
            SuffixesInt.Add(new Affix("of Adamantite Skin", 2, 56, "", "% increased Stun and Block Recovery", 23, 25, 1.32));
            SuffixesInt.Add(new Affix("of Corundum Skin", 1, 79, "", "% increased Stun and Block Recovery", 26, 28, 1.32));
            SuffixesInt.Add(new Affix("of Menace", 6, 11, "", "% increased Critical Strike Chance for Spells", 10, 19, 1.32));
            SuffixesInt.Add(new Affix("of Havoc", 5, 21, "", "% increased Critical Strike Chance for Spells", 20, 39, 1.32));
            SuffixesInt.Add(new Affix("of Disaster", 4, 28, "", "% increased Critical Strike Chance for Spells", 40, 59, 1.32));
            SuffixesInt.Add(new Affix("of Calamity", 3, 41, "", "% increased Critical Strike Chance for Spells", 60, 79, 1.32));
            SuffixesInt.Add(new Affix("of Ruin", 2, 59, "", "% increased Critical Strike Chance for Spells", 80, 99, 1.32));
            SuffixesInt.Add(new Affix("of Unmaking", 1, 76, "", "% increased Critical Strike Chance for Spells", 100, 109, 1.32));
            SuffixesInt.Add(new Affix("of Intercepting", 2, 10, "+", "% Chance to Block", 1, 3, 1.32));
            SuffixesInt.Add(new Affix("of Walling", 1, 58, "+", "% Chance to Block", 4, 6, 1.32));
            SuffixesInt.Add(new Affix("of the Worthy", 2, 36, "", "% reduced Attribute Requirements", 18, 18, 0.99));
            SuffixesInt.Add(new Affix("of the Apt", 1, 60, "", "% reduced Attribute Requirements", 32, 32, 0.99));
            SuffixesInt.Add(new Affix("of Redirection", 4, 15, "+", " Mana gained when you Block", 4, 12, 1.32));
            SuffixesInt.Add(new Affix("of Transformation", 3, 32, "+", " Mana gained when you Block", 13, 21, 1.32));
            SuffixesInt.Add(new Affix("of Conservation", 2, 58, "+", " Mana gained when you Block", 22, 30, 1.32));
            SuffixesInt.Add(new Affix("of Utilisation", 1, 75, "+", " Mana gained when you Block", 31, 39, 1.32));
            SuffixesInt.Add(new Affix("of the Barrier", 2, 30, "", "% Chance to Block Spells", 1, 3, 1.32));
            SuffixesInt.Add(new Affix("of the Bulwark", 1, 60, "", "% Chance to Block Spells", 4, 6, 1.32));
        }
    }
}

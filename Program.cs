using System;
using System.Collections.Generic;

namespace PoETestApp
{
    class Program
    {
        public static List<Affix> Prefixes { get; set; }
        public static List<Affix> Suffixes { get; set; }
        public static bool Running { get; set; }
        enum AffixType { Prefix, Suffix };

        static void Main(string[] args)
        {
            Item item = new Item() { MaxAffixes = 2, Name = "TestItem", BaseType = "TestBase" };
            Prefixes = new List<Affix>();
            Suffixes = new List<Affix>();
            CreateAffixes();

            Running = true;
            while (Running)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Action?\n" +
                    "'c' to chaos\n" +
                    "'d' to divine\n" +
                    "'p' to add prefix\n" +
                    "'s' to add suffix\n" +
                    "'q' to quit");
                HandleAction(Console.ReadLine(), item);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void HandleAction(string input, Item item)
        {
            switch (input)
            {
                case "p":
                    AddAffix(item, AffixType.Prefix);
                    break;
                case "s":
                    AddAffix(item, AffixType.Suffix);
                    break;
                case "c":
                    ChaosItem(item);
                    break;
                case "d":
                    DivineItem(item);
                    break;
                case "q":
                    Running = false;
                    break;
                default:
                    break;
            }
        }

        static void ChaosItem(Item item)
        {
            item.Prefixes.Clear();
            item.Suffixes.Clear();

            AddAffix(item, AffixType.Prefix);
            AddAffix(item, AffixType.Suffix);

            Random rnd = new Random();
            if (rnd.NextDouble() < 0.5)
                AddAffix(item, AffixType.Prefix);
            else
                AddAffix(item, AffixType.Suffix);

            if (item.Prefixes.Count < item.MaxAffixes)
            {
                if (rnd.NextDouble() < 0.5)
                {
                    AddAffix(item, AffixType.Prefix);
                    return;
                }                
            }
            else if (item.Suffixes.Count < item.MaxAffixes)
            {
                if (rnd.NextDouble() < 0.5)
                {
                    AddAffix(item, AffixType.Suffix);
                    return;
                }
            }
        }

        static void DivineItem(Item item)
        {
            Random rnd = new Random();
            foreach (Affix prefix in item.Prefixes)
                prefix.RollValue(rnd);
            foreach (Affix suffix in item.Suffixes)
                suffix.RollValue(rnd);
        }

        static void AddAffix(Item item, AffixType type)
        {
            Random rnd = new Random();
            Affix candidate = null;

            if (type == AffixType.Prefix)
            {
                if (item.Prefixes.Count < item.MaxAffixes)
                {
                    do
                    {
                        double variate = rnd.NextDouble();
                        double cumulative = 0.0;
                        foreach (Affix affix in Prefixes)
                        {
                            cumulative += affix.Weight / 100;
                            if (variate < cumulative)
                            {
                                candidate = affix;
                                break;
                            }
                        }
                        if (candidate == null)
                            candidate = Prefixes[Prefixes.Count - 1]; // If no match, return final element -- Only should happen if elements weights do not total 1
                    }
                    while (item.Prefixes.Contains(candidate));
                    item.Prefixes.Add(candidate);
                }
            }
            else if (type == AffixType.Suffix)
            {
                if (item.Suffixes.Count < item.MaxAffixes)
                {
                    do
                    {
                        double variate = rnd.NextDouble();
                        double cumulative = 0.0;
                        foreach (Affix affix in Suffixes)
                        {
                            cumulative += affix.Weight / 100;
                            if (variate < cumulative)
                            {
                                candidate = affix;
                                break;
                            }
                        }
                        if (candidate == null)
                            candidate = Suffixes[Suffixes.Count - 1]; // If no match, return final element -- Only should happen if elements weights do not total 1
                    }
                    while (item.Suffixes.Contains(candidate));
                    item.Suffixes.Add(candidate);
                }
            }
        }

        static void CreateAffixes()
        {
            Prefixes.Add(new Affix("Sinister", 1, 1, "", "% increased Physical Damage with Axes", 14, 16, 2.59));
            Prefixes.Add(new Affix("Vicious", 1, 1, "", "% increased Physical Damage with Swords", 14, 16, 2.59));
            Prefixes.Add(new Affix("Fierce", 1, 1, "", "% increased Physical Damage with Bows", 14, 16, 2.59));
            Prefixes.Add(new Affix("Savage", 1, 1, "", "% increased Physical Damage with Claws", 14, 16, 2.59));
            Prefixes.Add(new Affix("Lethal", 1, 1, "", "% increased Physical Damage with Daggers", 14, 16, 2.59));
            Prefixes.Add(new Affix("Soldier's", 1, 1, "", "% increased Physical Damage with One Handed Melee Weapons", 12, 14, 2.59));
            Prefixes.Add(new Affix("Champion's", 1, 1, "", "% increased Physical Damage with Two Handed Melee Weapons", 12, 14, 2.59));
            Prefixes.Add(new Affix("Gladiator's", 1, 1, "", "% increased Physical Weapon Damage while Dual Wielding", 12, 14, 2.59));
            Prefixes.Add(new Affix("Trapping", 1, 1, "", "% increased Trap Damage", 14, 16, 2.59));
            Prefixes.Add(new Affix("Sabotage", 1, 1, "", "% increased Mine Damage", 14, 16, 2.59));
            Prefixes.Add(new Affix("Flaming", 1, 1, "", "% increased Fire Damage", 14, 16, 2.07));
            Prefixes.Add(new Affix("Chilling", 1, 1, "", "% increased Cold Damage", 14, 16, 2.59));
            Prefixes.Add(new Affix("Humming", 1, 1, "", "% increased Lightning Damage", 14, 16, 2.07));
            Prefixes.Add(new Affix("Sharpened", 1, 1, "", "% increased Physical Damage", 14, 16, 2.59));
            Prefixes.Add(new Affix("Chaotic", 1, 1, "", "% increased Chaos Damage", 9, 13, 1.04));
            Prefixes.Add(new Affix("Cleaving", 1, 1, "", "% increased Attack Speed with Axes", 6, 8, 2.59));
            Prefixes.Add(new Affix("Fencing", 1, 1, "", "% increased Attack Speed with Swords", 6, 8, 2.59));
            Prefixes.Add(new Affix("Volleying", 1, 1, "", "% increased Attack Speed with Bows", 6, 8, 2.59));
            Prefixes.Add(new Affix("Ripping", 1, 1, "", "% increased Attack Speed with Claws", 6, 8, 2.59));
            Prefixes.Add(new Affix("Slicing", 1, 1, "", "% increased Attack Speed with Daggers", 6, 8, 2.59));
            Prefixes.Add(new Affix("Bandit's", 1, 1, "", "% increased Attack Speed with One Handed Melee Weapons", 4, 6, 2.59));
            Prefixes.Add(new Affix("Warrior's", 1, 1, "", "% increased Attack Speed with Two Handed Melee Weapons", 4, 6, 2.59));
            Prefixes.Add(new Affix("Harmonic", 1, 1, "", "% increased Attack Speed while Dual Wielding", 4, 6, 2.59));
            Prefixes.Add(new Affix("Charging", 1, 1, "", "% increased Attack Speed while holding a Shield", 4, 6, 2.59));
            Prefixes.Add(new Affix("Honed", 1, 1, "", "% increased Trap Throwing Speed", 6, 8, 1.3));
            Prefixes.Add(new Affix("Arming", 1, 1, "", "% increased Mine Laying Speed", 6, 8, 1.3));
            Prefixes.Add(new Affix("Flanking", 1, 1, "", "% increased Melee Physical Damage while holding a Shield", 12, 14, 2.59));
            Prefixes.Add(new Affix("Vivid", 1, 1, "", "% increased maximum Life", 5, 7, 1.81));
            Prefixes.Add(new Affix("Enlightened", 1, 1, "", "% increased maximum Mana", 6, 8, 2.59));
            Prefixes.Add(new Affix("Energetic", 1, 1, "", "% increased Mana Regeneration Rate", 12, 15, 1.3));
            Prefixes.Add(new Affix("Thirsting", 1, 1, "0.", "% of Physical Attack Damage Leeched as Mana", 2, 4, 1.3));
            Prefixes.Add(new Affix("Evasive", 1, 1, "", "% increased Evasion Rating", 14, 18, 2.59));
            Prefixes.Add(new Affix("Harming", 1, 1, "", "% increased Critical Strike Chance with One Handed Melee Weapons", 14, 18, 1.3));
            Prefixes.Add(new Affix("Sundering", 1, 1, "", "% increased Critical Strike Chance with Two Handed Melee Weapons", 14, 18, 1.3));
            Prefixes.Add(new Affix("Technical", 1, 1, "", "% increased Weapon Critical Strike Chance while Dual Wielding", 14, 18, 1.3));
            Prefixes.Add(new Affix("Incinerating", 1, 1, "", "% increased Critical Strike Chance with Fire Skills", 14, 18, 1.04));
            Prefixes.Add(new Affix("Avalanching", 1, 1, "", "% increased Critical Strike Chance with Cold Skills", 14, 18, 1.3));
            Prefixes.Add(new Affix("Thundering", 1, 1, "", "% increased Critical Strike Chance with Lightning Skills", 14, 18, 1.04));
            Prefixes.Add(new Affix("Piercing", 1, 1, "+", "% to Critical Strike Multiplier with One Handed Melee Weapons", 15, 18, 1.3));
            Prefixes.Add(new Affix("Rupturing", 1, 1, "+", "% to Critical Strike Multiplier with Two Handed Melee Weapons", 15, 18, 1.3));
            Prefixes.Add(new Affix("Puncturing", 1, 1, "+", "% to Critical Strike Multiplier while Dual Wielding", 15, 18, 1.3));
            Prefixes.Add(new Affix("Infernal", 1, 1, "+", "% to Critical Strike Multiplier with Fire Skills", 15, 18, 1.04));
            Prefixes.Add(new Affix("Arctic", 1, 1, "+", "% to Critical Strike Multiplier with Cold Skills", 15, 18, 1.3));
            Prefixes.Add(new Affix("Surging", 1, 1, "+", "% to Critical Strike Multiplier with Lightning Skills", 15, 18, 1.04));
            Prefixes.Add(new Affix("Parrying", 1, 1, "", "% additional Block Chance while Dual Wielding", 1, 1, 1.81));
            Prefixes.Add(new Affix("Shielding", 1, 1, "+", "% Chance to Block with Shields", 1, 1, 1.81));
            Prefixes.Add(new Affix("Dissipating", 1, 1, "", "% additional Chance to Block Spells while Dual Wielding", 1, 1, 1.81));
            Prefixes.Add(new Affix("Thwarting", 1, 1, "", "% additional Chance to Block Spells with Shields", 1, 1, 1.81));
            Prefixes.Add(new Affix("Shaman's", 1, 1, "", "% increased Totem Damage", 12, 16, 1.3));
            Prefixes.Add(new Affix("Carved", 1, 1, "", "% increased Totem Life", 8, 12, 1.3));

            Suffixes.Add(new Affix("of Combat", 1, 1, "", "% increased Melee Damage", 10, 12, 3.23));
            Suffixes.Add(new Affix("of Archery", 1, 1, "", "% increased Projectile Damage", 10, 12, 3.23));
            Suffixes.Add(new Affix("of Wounding", 1, 1, "", "% increased Damage", 8, 10, 2.26));
            Suffixes.Add(new Affix("of Entropy", 1, 1, "", "% increased Damage over Time", 10, 12, 3.23));
            Suffixes.Add(new Affix("of Blasting", 1, 1, "", "% increased Area Damage", 10, 12, 3.23));
            Suffixes.Add(new Affix("of Berserking", 1, 1, "", "% increased Attack Speed", 3, 5, 3.23));
            Suffixes.Add(new Affix("of Soaring", 1, 1, "", "% increased Projectile Speed", 6, 8, 3.23));
            Suffixes.Add(new Affix("of Zeal", 1, 1, "", "% increased Attack and Cast Speed", 2, 4, 2.26));
            Suffixes.Add(new Affix("of Strength", 1, 1, "+", " to Strength", 12, 16, 1.94));
            Suffixes.Add(new Affix("of Dexterity", 1, 1, "+", " to Dexterity", 12, 16, 3.23));
            Suffixes.Add(new Affix("of Intelligence", 1, 1, "+", " to Intelligence", 12, 16, 1.94));
            Suffixes.Add(new Affix("of Athletics", 1, 1, "+", " to Strength and Dexterity", 8, 10, 2.9));
            Suffixes.Add(new Affix("of Spirit", 1, 1, "+", " to Strength and Intelligence", 8, 10, 1.61));
            Suffixes.Add(new Affix("of Cunning", 1, 1, "+", " to Dexterity and Intelligence", 8, 10, 2.9));
            Suffixes.Add(new Affix("of Adaption", 1, 1, "+", " to all Attributes", 6, 8, 1.94));
            Suffixes.Add(new Affix("of Absorption", 1, 1, "+", " Mana gained for each Enemy hit by your Attacks", 1, 2, 3.23));
            Suffixes.Add(new Affix("of Raiding", 1, 1, "", "% increased Rarity of Items found", 4, 6, 0.97));
            Suffixes.Add(new Affix("of Precision", 1, 1, "", "% increased Accuracy Rating", 10, 14, 3.23));
            Suffixes.Add(new Affix("of Deadliness", 1, 1, "", "% increased Accuracy Rating", 6, 10, 0.97, "", "% increased Global Critical Strike Chance", 6, 10));
            Suffixes.Add(new Affix("of Menace", 1, 1, "", "% increased Global Critical Strike Chance", 8, 12, 1.61));
            Suffixes.Add(new Affix("of Potency", 1, 1, "+", "% to Global Critical Strike Multiplier", 9, 12, 1.61));
            Suffixes.Add(new Affix("of Weight", 1, 1, "", "% increased Melee Critical Strike Chance", 10, 14, 1.61));
            Suffixes.Add(new Affix("of the Apocalypse", 1, 1, "", "% increased Critical Strike Chance with Elemental Skills", 10, 14, 0.65));
            Suffixes.Add(new Affix("of Demolishing", 1, 1, "+", "% to Melee Critical Strike Multiplier", 12, 15, 1.61));
            Suffixes.Add(new Affix("of the Elements", 1, 1, "+", "% to Critical Strike Multiplier with Elemental Skills", 12, 15, 0.65));
            Suffixes.Add(new Affix("of the Dragon", 1, 1, "+", "% to Fire Resistance", 12, 15, 1.94));
            Suffixes.Add(new Affix("of the Beast", 1, 1, "+", "% to Cold Resistance", 12, 15, 3.23));
            Suffixes.Add(new Affix("of Grounding", 1, 1, "+", "% to Lightning Resistance", 12, 15, 1.94));
            Suffixes.Add(new Affix("of the Hearth", 1, 1, "+", "% to Fire and Cold Resistances", 10, 12, 2.9));
            Suffixes.Add(new Affix("of Insulation", 1, 1, "+", "% to Fire and Lightning Resistances", 10, 12, 1.61));
            Suffixes.Add(new Affix("of Shelter", 1, 1, "+", "% to Cold and Lightning Resistances", 10, 12, 2.9));
            Suffixes.Add(new Affix("of Resistance", 1, 1, "+", "% to all Elemental Resistances", 8, 10, 1.94));
            Suffixes.Add(new Affix("of Order", 1, 1, "+", "% to Chaos Resistance", 7, 13, 0.65));
            Suffixes.Add(new Affix("of Stunning", 1, 1, "", "% increased Stun Duration on Enemies", 10, 14, 1.29));
            Suffixes.Add(new Affix("of Recovery", 1, 1, "", "% increased Stun and Block Recovery", 10, 14, 1.29));
            Suffixes.Add(new Affix("of Efficiency", 1, 1, "", "% reduced Mana Cost of Skills", 3, 5, 3.23));
            Suffixes.Add(new Affix("of Fending", 1, 1, "", "% chance to Knock Enemies Back on hit", 4, 6, 1.61));
            Suffixes.Add(new Affix("of Freezing", 1, 1, "", "% chance to Freeze", 3, 5, 2.26, "", "% increased Freeze Duration on Enemies", 12, 16));
            Suffixes.Add(new Affix("of Shocking", 1, 1, "", "% chance to Shock", 3, 5, 1.61, "", "% increased Shock Duration on Enemies", 12, 16));
            Suffixes.Add(new Affix("of Burning", 1, 1, "", "% chance to Ignite", 3, 5, 1.61, "", "% increased Ignite Duration on Enemies", 6, 8));
            Suffixes.Add(new Affix("of Poisoning", 1, 1, "", "% chance to Poison on Hit", 3, 5, 2.26, "", "% increased Poison Duration", 6, 8));
            Suffixes.Add(new Affix("of Bleeding", 1, 1, "Attacks have ", "% chance to cause Bleeding", 3, 5, 1.61, "", "% increased Bleed duration", 12, 16));
            Suffixes.Add(new Affix("of Venom", 1, 1, "", "% increased Damage with Poison", 16, 20, 3.23));
            Suffixes.Add(new Affix("of Haemophilia", 1, 1, "", "% increased Damage with Bleeding", 16, 20, 1.61));
            Suffixes.Add(new Affix("of Combusting", 1, 1, "", "% increased Burning Damage", 16, 20, 3.23));
            Suffixes.Add(new Affix("of Runes", 1, 1, "Totems gain +", "% to all Elemental Resistances", 6, 10, 1.61));
        }
    }
}
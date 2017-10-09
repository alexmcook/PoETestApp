using System;
using System.Collections.Generic;
using System.Text;

namespace PoETestApp
{
    class Item
    {
        public List<Affix> Prefixes { get; set; }
        public List<Affix> Suffixes { get; set; }
        public int MaxAffixes { get; set; }
        public string BaseType { get; set; }
        public string Name { get; set; }

        public Item()
        {
            Prefixes = new List<Affix>();
            Suffixes = new List<Affix>();
        }

        public Item(string name, string baseType, int maxAffixes)
        {
            this.Name = name;
            this.BaseType = baseType;
            this.MaxAffixes = maxAffixes;
            Prefixes = new List<Affix>();
            Suffixes = new List<Affix>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name).Append(" - ").Append(BaseType).Append("\n");
            if (Prefixes.Count > 0 || Suffixes.Count > 0)
                sb.Append("------\n");
            foreach (Affix prefix in Prefixes)
            {
                sb.Append(prefix.ToString()).Append("\n");
            }
            if (Suffixes.Count > 0)
                sb.Append("---\n");
            foreach (Affix suffix in Suffixes)
            {
                sb.Append(suffix.ToString()).Append("\n");
            }
            return sb.ToString();
        }
    }
}

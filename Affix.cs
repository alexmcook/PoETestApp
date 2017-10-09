using System;
using System.Collections.Generic;
using System.Text;

namespace PoETestApp
{
    class Affix
    {
        public int Tier { get; set; }
        public int ILvl { get; set; }
        public string Name { get; set; }
        public string PreText { get; set; }
        public string Text { get; set; }
        public double Weight { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }
        public bool Hybrid { get; set; }
        public string HybridPreText { get; set; }
        public string HybridText { get; set; }
        public int HybridMinValue { get; set; }
        public int HybridMaxValue { get; set; }
        public int HybridValue { get; set; }

        public Affix(string name, int tier, int iLvl, string preText, string text, int minValue, int maxValue, double weight)
        {
            this.Name = name;
            this.Tier = tier;
            this.ILvl = iLvl;
            this.PreText = preText;
            this.Text = text;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Weight = weight;
            this.Hybrid = false;
            Random rnd = new Random();
            RollValue(rnd);
        }

        public Affix(string name, int tier, int iLvl, string preText, string text, int minValue, int maxValue, double weight, 
            string hybridPreText, string hybridText, int hybridMinValue, int hybridMaxValue)
        {
            this.Name = name;
            this.Tier = tier;
            this.ILvl = iLvl;
            this.PreText = preText;
            this.Text = text;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Weight = weight;
            this.Hybrid = true;
            this.HybridPreText = hybridPreText;
            this.HybridText = hybridText;
            this.HybridMinValue = hybridMinValue;
            this.HybridMaxValue = hybridMaxValue;
            Random rnd = new Random();
            RollValue(rnd);
        }

        public void RollValue(Random rnd)
        {
            this.Value = rnd.Next(this.MinValue, this.MaxValue + 1);
            if (this.Hybrid)
                this.HybridValue = rnd.Next(this.HybridMinValue, this.HybridMaxValue);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(PreText).Append(Value).Append(Text);
            if (Hybrid)
                sb.Append("\n").Append(HybridPreText).Append(HybridValue).Append(HybridText);
            return sb.ToString();
        }
    }
}

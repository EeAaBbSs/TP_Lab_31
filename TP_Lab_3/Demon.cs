using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Demon : Monster
    {
        private string wingsMaterial = "";
        private string hornsMaterial = "";
        public Demon(string type, string wingsMaterial, string hornsMaterial) : base(type)
        {
            if (string.IsNullOrWhiteSpace(wingsMaterial) || string.IsNullOrWhiteSpace(hornsMaterial))
                { throw new ArgumentException("Invalid format of entering parameter"); }
            this.hornsMaterial = hornsMaterial;
            this.wingsMaterial = wingsMaterial;
        }  
        public new string Info()
        {
            return base.Info() + $", has a following characteristics:\nMaterial of wings: {wingsMaterial}\nMaterial of horns: {hornsMaterial}"; 
        }
    }
}

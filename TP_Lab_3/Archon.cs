using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Archon : Demon
    {
        private int iq;
        public Archon(string type, string wingsMaterial, string hornsMaterial, int iq) : base(type, wingsMaterial, hornsMaterial)
        {
            if (iq < 300) 
                { throw new ArgumentException("IQ of Archon cant be below than 300"); }
            this.iq = iq;
        }
        public new string Info()
        {
            return base.Info() + "\nIQ: " + Convert.ToString(iq);
        }
    }
}

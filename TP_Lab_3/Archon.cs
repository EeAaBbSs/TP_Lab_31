using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Archon : Demon
    {
        private string highIntelligence = "High intellegence";
        public new string Info()
        {
            return base.Info() + ", " + highIntelligence;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Demon : Monster
    {
        private string wings = "Wings";
        private string horns = "Horns";  
        public new string Info()
        {
            return base.Info() + $", has a following characteristics: {wings}, {horns}"; 
        }
    }
}

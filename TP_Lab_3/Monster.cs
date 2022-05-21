using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Monster
    {
        private string type = "";
        public Monster(string type)
        {
            if (type == "Enemy" || type == "enemy" || type == "Ally" || type == "ally")
                { this.type = type; }
            else 
                { throw new ArgumentException("Invalid format of entering parameter"); }
        }
        public string Info()
        {
            return $"Type: {type}";
        }
    }
}

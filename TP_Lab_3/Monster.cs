using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Monster
    {
        private string type = "Enemy"; 
        public string Info()
        {
            return $"Type: {type}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    class Monster
    {
        protected string type = "Enemy"; 
        public virtual void Info()
        {
            Console.WriteLine($"Type: {type}");
        }
    }
}

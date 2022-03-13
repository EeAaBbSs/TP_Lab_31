using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    class Demon : Monster
    {
        protected bool wings = true;
        protected bool horns = true;
        
        public void CanFly()
        {
            Console.WriteLine("Yes");
        }
        public void HaveHorns()
        {
            Console.WriteLine("Yes");
        }
    }
}

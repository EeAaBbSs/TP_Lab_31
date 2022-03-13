using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    class CoveredNotebook : Notebook
    {
        private const string cover = "Hard";
        public void OpenBook()
        {
            Console.WriteLine("Page 1: " + list1.Text);
            Console.WriteLine("Page 2: " + list2.Text);
            Console.WriteLine("Page 3: " + list3.Text);
            Console.WriteLine("Page 4: " + list4.Text);
            Console.WriteLine("Page 5: " + list5.Text);
        }
    }
}

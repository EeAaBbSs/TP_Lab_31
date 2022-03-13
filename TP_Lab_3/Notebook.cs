using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    class Notebook
    {
        private const string cover = "Soft";
        protected ListOfPaper list1 = new ListOfPaper("Text of the first page.");
        protected ListOfPaper list2 = new ListOfPaper("Text of the second page.");
        protected ListOfPaper list3 = new ListOfPaper("Text of the third page.");
        protected ListOfPaper list4 = new ListOfPaper("Text of the fourth page.");
        protected ListOfPaper list5 = new ListOfPaper("Text of the fifth page.");
        /*public void CoverInfo()
        {
            Console.WriteLine("Type of cover: " + cover);
        }*/
    }
}

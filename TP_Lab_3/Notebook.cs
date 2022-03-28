using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Notebook
    {
        private List<ListOfPaper> notebookList = new List<ListOfPaper>();
        private ListOfPaper list1 = new ListOfPaper("Text of the first page.");
        private ListOfPaper list2 = new ListOfPaper("Text of the second page.");
        private ListOfPaper list3 = new ListOfPaper("Text of the third page.");
        private ListOfPaper list4 = new ListOfPaper("Text of the fourth page.");
        private ListOfPaper list5 = new ListOfPaper("Text of the fifth page.");
        public Notebook()
        {
            notebookList.Add(list1);
            notebookList.Add(list2);
            notebookList.Add(list3);
            notebookList.Add(list4);
            notebookList.Add(list5);
        }
        public string Info()
        {
            string str = "";
            for (int i = 0; i < notebookList.Count; i++)
            {
                str += string.Concat(notebookList[i].Text, "\n");
            }
            return "Number of pages " + notebookList.Count + "\n" + str;
        }
    }
}

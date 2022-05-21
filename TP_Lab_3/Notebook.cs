using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class Notebook
    {
        private List<ListOfPaper> notebookList = new List<ListOfPaper>();
        public Notebook(int noP)
        {
            if (noP <= 0) 
                { throw new ArgumentException("Number of page cant be below than zero or equal"); }
            for (int i = 0; i < noP; i++)
            {
                ListOfPaper p = new ListOfPaper("Text of the " + Convert.ToString(i+1) + " page");
                notebookList.Add(p);
            }
        }
        public string Info()
        {
            string str = "";
            for (int i = 0; i < notebookList.Count; i++)
            {
                str += string.Concat(notebookList[i].Text, "\n");
            }
            return "Number of pages: " + notebookList.Count + "\n" + str;
        }
    }
}

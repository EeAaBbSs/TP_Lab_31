using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class CoveredNotebook : Notebook
    {
        private string cover = "Hard";
        public new string Info()
        {
            return $"Type of cover: {cover}\n{base.Info()}";
        }
    }
}

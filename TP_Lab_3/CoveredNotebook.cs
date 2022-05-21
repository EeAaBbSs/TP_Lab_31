using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_3
{
    public class CoveredNotebook : Notebook
    {
        private string covMaterial = "";
        public CoveredNotebook(int noP, string covMaterial) : base (noP)
        {
            if (string.IsNullOrWhiteSpace(covMaterial))
                { throw new ArgumentException("Invalid format of entering parameter"); }
            this.covMaterial = covMaterial;
        }
        public new string Info()
        {
            return $"Cover material: {covMaterial}\n{base.Info()}";
        }
    }
}

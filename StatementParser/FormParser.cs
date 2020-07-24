﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatementParser
{
    public partial class FormParser : Form
    {
        public FormParser()
        {
            InitializeComponent();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            String temp = "";
            
            foreach (String line in textBoxOriginal.Lines)
            {
                if(line.StartsWith("JAN")
                    || line.StartsWith("FEB")
                    || line.StartsWith("MAR")
                    || line.StartsWith("APR")
                    || line.StartsWith("MAY")
                    || line.StartsWith("JUN")
                    || line.StartsWith("JUL")
                    || line.StartsWith("AUG")
                    || line.StartsWith("SEP")
                    || line.StartsWith("OCT")
                    || line.StartsWith("NOV")
                    || line.StartsWith("DEC"))
                {
                    temp = line;
                }
                else if (line.StartsWith("$"))
                {
                    textBoxParsed.AppendText(line.Replace("$", "") + "\t" + temp + Environment.NewLine);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PeristalticPump
{
    public partial class Form2 : Form
    {
        public Form1 masterForm_1; 
        int fontsize = 11;
        int offset = 4;
        
        public Form2(PeristalticPump.Form1 masterForm_2)
        {
            masterForm_1 = masterForm_2;
            InitializeComponent();            

            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Bold);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = "Software for fully automated measurements with peristaltic" + Environment.NewLine + "pump and with optical character recognition (OCR)" + Environment.NewLine;
                 
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = "Author: Ján Tóth" + Environment.NewLine; 
         
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = "Contact e-mail:";

            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = " jantoth92@gmail.com" + Environment.NewLine ;
            
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = "Source code under Apache License 2.0." + Environment.NewLine;

            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = "Copyright © 2021" + Environment.NewLine;

            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            richTextBox1.SelectionCharOffset = offset;
            richTextBox1.SelectedText = "If you use this software to collect any scientific data please cite this article.  " + Environment.NewLine + "doi: https://doi.org/10.1016/j.talanta.2021.122185";
        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            masterForm_1.aboutToolStripMenuItem1.Enabled = true;
        }      

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
           Process.Start("IExplore.exe", e.LinkText);
        }
    }
}

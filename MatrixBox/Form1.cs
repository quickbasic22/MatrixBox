using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MatrixBox
{
    public partial class Form1 : Form
    {
        string displayString = "This is a very long string to measure how much space is needed";
        Font font8 = new Font("Arial", 8);
        Font font12 = new Font("Arial", 12);
        Font font24 = new Font("Arial", 24);
        Font font36 = new Font("Arial", 36);
        int fontVar = 0;
        SizeF sizeF;
        public Graphics e;



        public Form1()
        {
            InitializeComponent();
            e = label1.CreateGraphics();
            
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 3;
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs evt)
        {
            
            fontVar = Int32.Parse(numericUpDown1.Value.ToString());
            switch (fontVar)
            {
                case 0:
                    label2.Text = "Arial 8";
                    label3.Text = e.MeasureString(displayString, font8).ToString();
                    label1.Font = font8;
                    break;
                case 1:
                    label2.Text = "Arial 12";
                   label3.Text = e.MeasureString(displayString, font12).ToString();
                    label1.Font = font12;
                    break;
                case 2:
                    label2.Text = "Arial 24";
                    label3.Text = e.MeasureString(displayString, font24).ToString();
                    label1.Font = font24;
                    break;
                case 3:
                    label2.Text = "Arial 36";
                    label3.Text = e.MeasureString(displayString, font36).ToString();
                    label1.Font = font36;
                    break;
            }
        }

        
    }
}

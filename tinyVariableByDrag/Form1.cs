using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tinyVariableByDrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.baraVerticala1.BringToFront();
            this.baraHctrl1.minLeft = 100;
            this.baraHctrl1.maxLeft = 200;
            this.baraHctrl1.minTop = 200;
            this.baraHctrl1.maxTop = 200;
            this.baraHctrl1.Left = 100;
            this.baraHctrl1.Top = 200;
            this.baraVerticala1.Top = (int)this.baraHctrl1.minTop + this.baraHctrl1.Height/2;
            this.baraVerticala1.Left = (int)this.baraHctrl1.minLeft;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = this.baraHctrl1.getValueOfLeft().ToString();
        }

        
    }
}

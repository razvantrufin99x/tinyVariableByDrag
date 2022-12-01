using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tinyVariableByDrag
{
    public partial class baraHctrl : UserControl
    {
        public baraHctrl()
        {
            InitializeComponent();
        }

        

        int ismd = 0;

        public float minLeft = 0;
        public float maxLeft = 0;
        public float maxTop = 0;
        public float minTop = 0;

        public void setPozitions(float ml, float xl, float mt, float xt){
            minLeft = ml;
            maxLeft = xl;
            maxTop = xt;
            minTop = mt;
        }

        public float getValueOfLeft()
        {
            return minLeft + Left;
        }
        private void baraHctrl_Load(object sender, EventArgs e)
        {

        }

        private void baraHctrl_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void baraHctrl_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void baraHctrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1) {
                Left += e.X;
                Top += e.Y;

                if (Left < minLeft) { Left = (int)minLeft; }
                if (Left > maxLeft) { Left = (int)maxLeft; }
                if (Top < minTop) { Top = (int)minTop; }
                if (Top > maxTop) { Top = (int)maxTop; } 


            }
        }

        private void baraHctrl_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}

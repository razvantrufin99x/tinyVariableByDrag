namespace tinyVariableByDrag
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.baraVerticala1 = new tinyVariableByDrag.baraVerticala();
            this.baraHctrl1 = new tinyVariableByDrag.baraHctrl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baraVerticala1
            // 
            this.baraVerticala1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.baraVerticala1.Location = new System.Drawing.Point(68, 84);
            this.baraVerticala1.Margin = new System.Windows.Forms.Padding(0);
            this.baraVerticala1.Name = "baraVerticala1";
            this.baraVerticala1.Size = new System.Drawing.Size(100, 2);
            this.baraVerticala1.TabIndex = 2;
            // 
            // baraHctrl1
            // 
            this.baraHctrl1.BackColor = System.Drawing.Color.Silver;
            this.baraHctrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baraHctrl1.Location = new System.Drawing.Point(111, 69);
            this.baraHctrl1.Margin = new System.Windows.Forms.Padding(0);
            this.baraHctrl1.Name = "baraHctrl1";
            this.baraHctrl1.Size = new System.Drawing.Size(11, 33);
            this.baraHctrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 399);
            this.Controls.Add(this.baraHctrl1);
            this.Controls.Add(this.baraVerticala1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private baraHctrl baraHctrl1;
        private System.Windows.Forms.Button button1;
        private baraVerticala baraVerticala1;
    }
}


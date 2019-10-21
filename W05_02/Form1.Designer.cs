namespace W05_02
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
            this.computerControl2 = new W05_02.ComputerControl();
            this.computerControl1 = new W05_02.ComputerControl();
            this.SuspendLayout();
            // 
            // computerControl2
            // 
            this.computerControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.computerControl2.Location = new System.Drawing.Point(0, 373);
            this.computerControl2.Name = "computerControl2";
            this.computerControl2.Size = new System.Drawing.Size(1393, 371);
            this.computerControl2.TabIndex = 1;
            this.computerControl2.Title = "Computer 02";
            // 
            // computerControl1
            // 
            this.computerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.computerControl1.Location = new System.Drawing.Point(0, 0);
            this.computerControl1.Name = "computerControl1";
            this.computerControl1.Size = new System.Drawing.Size(1393, 373);
            this.computerControl1.TabIndex = 0;
            this.computerControl1.Title = "Computer 01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 809);
            this.Controls.Add(this.computerControl2);
            this.Controls.Add(this.computerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComputerControl computerControl1;
        private ComputerControl computerControl2;
    }
}


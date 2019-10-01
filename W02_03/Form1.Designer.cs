namespace W02_03
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.groupFont = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(0, 0);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(647, 996);
            this.tbText.TabIndex = 0;
            // 
            // groupFont
            // 
            this.groupFont.Controls.Add(this.radioButton4);
            this.groupFont.Controls.Add(this.radioButton3);
            this.groupFont.Controls.Add(this.radioButton2);
            this.groupFont.Controls.Add(this.radioButton1);
            this.groupFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFont.Location = new System.Drawing.Point(647, 0);
            this.groupFont.Name = "groupFont";
            this.groupFont.Size = new System.Drawing.Size(925, 996);
            this.groupFont.TabIndex = 1;
            this.groupFont.TabStop = false;
            this.groupFont.Text = "Fonts";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.radioButton1.Location = new System.Drawing.Point(27, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 73);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Arial";
            this.radioButton1.Text = "Arial";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 18F);
            this.radioButton2.Location = new System.Drawing.Point(27, 173);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(225, 77);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "Calibri";
            this.radioButton2.Text = "Calibri";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.radioButton3.Location = new System.Drawing.Point(27, 285);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(430, 80);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "Trebuchet MS";
            this.radioButton3.Text = "Trebuchet MS";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.radioButton4.Location = new System.Drawing.Point(27, 384);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(517, 101);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "Viner Hand ITC";
            this.radioButton4.Text = "Viner Hand ITC";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 996);
            this.Controls.Add(this.groupFont);
            this.Controls.Add(this.tbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupFont.ResumeLayout(false);
            this.groupFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.GroupBox groupFont;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


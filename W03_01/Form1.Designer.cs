namespace W03_01
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBoldItalic = new System.Windows.Forms.CheckBox();
            this.rdbAutoColor = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbAlignLeft = new System.Windows.Forms.RadioButton();
            this.rdbAlignRight = new System.Windows.Forms.RadioButton();
            this.rdbAlignCenter = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Location = new System.Drawing.Point(50, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1547, 284);
            this.panel1.TabIndex = 0;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(42, 108);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(1469, 69);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit\r\n";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(284, 390);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoldItalic);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.chkRegular);
            this.groupBox1.Location = new System.Drawing.Point(50, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 577);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbBlue);
            this.groupBox2.Controls.Add(this.rdbGreen);
            this.groupBox2.Controls.Add(this.rdbRed);
            this.groupBox2.Controls.Add(this.rdbAutoColor);
            this.groupBox2.Location = new System.Drawing.Point(498, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 577);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbAlignCenter);
            this.groupBox3.Controls.Add(this.rdbAlignRight);
            this.groupBox3.Controls.Add(this.rdbAlignLeft);
            this.groupBox3.Location = new System.Drawing.Point(1059, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 577);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TextAlign";
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(24, 66);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(153, 36);
            this.chkRegular.TabIndex = 0;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(24, 142);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(111, 36);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(24, 223);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(112, 36);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBoldItalic
            // 
            this.chkBoldItalic.AutoSize = true;
            this.chkBoldItalic.Location = new System.Drawing.Point(24, 299);
            this.chkBoldItalic.Name = "chkBoldItalic";
            this.chkBoldItalic.Size = new System.Drawing.Size(200, 36);
            this.chkBoldItalic.TabIndex = 3;
            this.chkBoldItalic.Text = "Bold + Italic";
            this.chkBoldItalic.UseVisualStyleBackColor = true;
            // 
            // rdbAutoColor
            // 
            this.rdbAutoColor.AutoSize = true;
            this.rdbAutoColor.Location = new System.Drawing.Point(40, 65);
            this.rdbAutoColor.Name = "rdbAutoColor";
            this.rdbAutoColor.Size = new System.Drawing.Size(179, 36);
            this.rdbAutoColor.TabIndex = 0;
            this.rdbAutoColor.TabStop = true;
            this.rdbAutoColor.Text = "AutoColor";
            this.rdbAutoColor.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(40, 141);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(104, 36);
            this.rdbRed.TabIndex = 1;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(40, 223);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(131, 36);
            this.rdbGreen.TabIndex = 2;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(40, 298);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(110, 36);
            this.rdbBlue.TabIndex = 3;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbAlignLeft
            // 
            this.rdbAlignLeft.AutoSize = true;
            this.rdbAlignLeft.Location = new System.Drawing.Point(40, 66);
            this.rdbAlignLeft.Name = "rdbAlignLeft";
            this.rdbAlignLeft.Size = new System.Drawing.Size(100, 36);
            this.rdbAlignLeft.TabIndex = 0;
            this.rdbAlignLeft.TabStop = true;
            this.rdbAlignLeft.Text = "Left";
            this.rdbAlignLeft.UseVisualStyleBackColor = true;
            // 
            // rdbAlignRight
            // 
            this.rdbAlignRight.AutoSize = true;
            this.rdbAlignRight.Location = new System.Drawing.Point(40, 142);
            this.rdbAlignRight.Name = "rdbAlignRight";
            this.rdbAlignRight.Size = new System.Drawing.Size(119, 36);
            this.rdbAlignRight.TabIndex = 1;
            this.rdbAlignRight.TabStop = true;
            this.rdbAlignRight.Text = "Right";
            this.rdbAlignRight.UseVisualStyleBackColor = true;
            // 
            // rdbAlignCenter
            // 
            this.rdbAlignCenter.AutoSize = true;
            this.rdbAlignCenter.Location = new System.Drawing.Point(40, 223);
            this.rdbAlignCenter.Name = "rdbAlignCenter";
            this.rdbAlignCenter.Size = new System.Drawing.Size(137, 36);
            this.rdbAlignCenter.TabIndex = 2;
            this.rdbAlignCenter.TabStop = true;
            this.rdbAlignCenter.Text = "Center";
            this.rdbAlignCenter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 1144);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBoldItalic;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbAutoColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbAlignCenter;
        private System.Windows.Forms.RadioButton rdbAlignRight;
        private System.Windows.Forms.RadioButton rdbAlignLeft;
    }
}


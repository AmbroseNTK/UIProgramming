namespace W02_02
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
            this.lbText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.radBold = new System.Windows.Forms.RadioButton();
            this.radItalic = new System.Windows.Forms.RadioButton();
            this.radBoldItalic = new System.Windows.Forms.RadioButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btSelectFont = new System.Windows.Forms.Button();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.btColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(629, 54);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(239, 46);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Hello World";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1613, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSelectFont);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 906);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Style";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btColor);
            this.groupBox3.Controls.Add(this.radGreen);
            this.groupBox3.Controls.Add(this.radBlue);
            this.groupBox3.Controls.Add(this.radRed);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(753, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 906);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radBoldItalic);
            this.groupBox4.Controls.Add(this.radItalic);
            this.groupBox4.Controls.Add(this.radBold);
            this.groupBox4.Controls.Add(this.radRegular);
            this.groupBox4.Location = new System.Drawing.Point(26, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 245);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Location = new System.Drawing.Point(22, 51);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(152, 36);
            this.radRegular.TabIndex = 0;
            this.radRegular.TabStop = true;
            this.radRegular.Tag = "Regular";
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radBold
            // 
            this.radBold.AutoSize = true;
            this.radBold.Location = new System.Drawing.Point(22, 93);
            this.radBold.Name = "radBold";
            this.radBold.Size = new System.Drawing.Size(110, 36);
            this.radBold.TabIndex = 1;
            this.radBold.TabStop = true;
            this.radBold.Tag = "Bold";
            this.radBold.Text = "Bold";
            this.radBold.UseVisualStyleBackColor = true;
            // 
            // radItalic
            // 
            this.radItalic.AutoSize = true;
            this.radItalic.Location = new System.Drawing.Point(22, 135);
            this.radItalic.Name = "radItalic";
            this.radItalic.Size = new System.Drawing.Size(111, 36);
            this.radItalic.TabIndex = 2;
            this.radItalic.TabStop = true;
            this.radItalic.Tag = "Italic";
            this.radItalic.Text = "Italic";
            this.radItalic.UseVisualStyleBackColor = true;
            // 
            // radBoldItalic
            // 
            this.radBoldItalic.AutoSize = true;
            this.radBoldItalic.Location = new System.Drawing.Point(22, 177);
            this.radBoldItalic.Name = "radBoldItalic";
            this.radBoldItalic.Size = new System.Drawing.Size(199, 36);
            this.radBoldItalic.TabIndex = 3;
            this.radBoldItalic.TabStop = true;
            this.radBoldItalic.Tag = "BoldItalic";
            this.radBoldItalic.Text = "Bold + Italic";
            this.radBoldItalic.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(174, 57);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(503, 38);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.TbInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // btSelectFont
            // 
            this.btSelectFont.Location = new System.Drawing.Point(338, 138);
            this.btSelectFont.Name = "btSelectFont";
            this.btSelectFont.Size = new System.Drawing.Size(339, 54);
            this.btSelectFont.TabIndex = 3;
            this.btSelectFont.Text = "Select Font";
            this.btSelectFont.UseVisualStyleBackColor = true;
            this.btSelectFont.Click += new System.EventHandler(this.BtSelectFont_Click);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(45, 58);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(104, 36);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Tag = "Red";
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(45, 124);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(110, 36);
            this.radBlue.TabIndex = 1;
            this.radBlue.TabStop = true;
            this.radBlue.Tag = "Blue";
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(45, 195);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(131, 36);
            this.radGreen.TabIndex = 2;
            this.radGreen.TabStop = true;
            this.radGreen.Tag = "Green";
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // btColor
            // 
            this.btColor.Location = new System.Drawing.Point(45, 272);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(215, 65);
            this.btColor.TabIndex = 3;
            this.btColor.Text = "Select Color";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.BtColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 1057);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSelectFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radBoldItalic;
        private System.Windows.Forms.RadioButton radItalic;
        private System.Windows.Forms.RadioButton radBold;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

